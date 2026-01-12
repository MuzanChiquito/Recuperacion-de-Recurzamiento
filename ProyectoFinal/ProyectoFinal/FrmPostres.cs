using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Printing;


namespace ProyectoFinal
{
    public partial class FrmPostres : Form
    {
    	PrintDocument printDocument = new PrintDocument();

        MySqlConnection conPostres = new MySqlConnection(
   		 "server=localhost;database=dbPostress;uid=root;pwd=;");

        public FrmPostres()
		{
   			InitializeComponent();
    		ConfigurarListView();
    		printDocument.PrintPage += PrintDocument_PrintPage;
		}


     
        private void FrmPostresLoad(object sender, EventArgs e)
        {
            try
            {
                conPostres.Open();
                MessageBox.Show("Conexión a db_Postres exitosa");
                conPostres.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void RbSaladosCheckedChanged(object sender, EventArgs e)
        {
            if (RbSalados.Checked)
                CargarProductos("Salado");
        }

        private void rbDulcesCheckedChanged(object sender, EventArgs e)
        {
            if (rbDulces.Checked)
                CargarProductos("Dulce");
        }

        
        void CargarProductos(string tipo)
        {
            try
            {
                conPostres.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT nombre FROM postres WHERE tipo=@tipo", conPostres);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                MySqlDataReader dr = cmd.ExecuteReader();
                cboProductos.Items.Clear();

                while (dr.Read())
                {
                    cboProductos.Items.Add(dr["nombre"].ToString());
                }

                conPostres.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void cboProductosSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conPostres.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT precio FROM postres WHERE nombre=@nombre", conPostres);
                cmd.Parameters.AddWithValue("@nombre", cboProductos.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                    txtPrecio.Text = dr["precio"].ToString();

                conPostres.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void TxtCantidadTextChanged(object sender, EventArgs e)
        {
            CalcularTotalProducto();
        }

        void CalcularTotalProducto()
        {
            decimal precio;
            int cantidad;

            if (decimal.TryParse(txtPrecio.Text, out precio) &&
                int.TryParse(txtCantidad.Text, out cantidad))
                txtTotal.Text = (precio * cantidad).ToString();
            else
                txtTotal.Text = "0";
        }

        
        void ConfigurarListView()
        {
            lvDetalle.View = View.Details;
            lvDetalle.FullRowSelect = true;
            lvDetalle.GridLines = true;

            lvDetalle.Columns.Clear();
            lvDetalle.Columns.Add("Producto", 120);
            lvDetalle.Columns.Add("Precio", 80);
            lvDetalle.Columns.Add("Cantidad", 80);
            lvDetalle.Columns.Add("Total", 90);
        }

        
        void BtnAgregarClick(object sender, EventArgs e)
        {
            if (cboProductos.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Seleccione un producto y cantidad");
                return;
            }

            ListViewItem item = new ListViewItem(cboProductos.Text);
            item.SubItems.Add(txtPrecio.Text);
            item.SubItems.Add(txtCantidad.Text);
            item.SubItems.Add(txtTotal.Text);

            lvDetalle.Items.Add(item);

            CalcularSubtotal();
            LimpiarProducto();
        }

        
        void CalcularSubtotal()
        {
            decimal subtotal = 0;

            foreach (ListViewItem item in lvDetalle.Items)
                subtotal += decimal.Parse(item.SubItems[3].Text);

            txtSubtotal.Text = subtotal.ToString();
            CalcularImporteNeto();

        }

        void LimpiarProducto()
        {
            cboProductos.SelectedIndex = -1;
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();
        }

        
        private void BtnGuardarClick(object sender, EventArgs e)
        {
            if (lvDetalle.Items.Count == 0)
            {
                MessageBox.Show("No hay productos para guardar");
                return;
            }

            decimal totalVenta = decimal.Parse(txtSubtotal.Text);

            try
            {
                conPostres.Open();

MySqlCommand cmdVenta = new MySqlCommand(
    "INSERT INTO ventas (fecha, total) VALUES (@fecha, @total)",
    conPostres);

cmdVenta.Parameters.AddWithValue("@fecha", DateTime.Now);
cmdVenta.Parameters.AddWithValue("@total", totalVenta);

cmdVenta.ExecuteNonQuery();
int idVenta = (int)cmdVenta.LastInsertedId;

foreach (ListViewItem item in lvDetalle.Items)
{
    MySqlCommand cmdDetalle = new MySqlCommand(
        "INSERT INTO detalle_venta (id_ventas, producto, cantidad, precio, total) " +
        "VALUES (@id, @producto, @cantidad, @precio, @total)", conPostres);

    cmdDetalle.Parameters.AddWithValue("@id", idVenta);
    cmdDetalle.Parameters.AddWithValue("@producto", item.SubItems[0].Text);
    cmdDetalle.Parameters.AddWithValue("@cantidad", item.SubItems[2].Text);
    cmdDetalle.Parameters.AddWithValue("@precio", item.SubItems[1].Text);
    cmdDetalle.Parameters.AddWithValue("@total", item.SubItems[3].Text);

    cmdDetalle.ExecuteNonQuery();

}

conPostres.Close();


                MessageBox.Show("Venta guardada correctamente");
                lvDetalle.Items.Clear();
                txtSubtotal.Clear();
          

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BtnEliminarClick(object sender, EventArgs e)
			{
   				 if (lvDetalle.SelectedItems.Count == 0)
    		{
       			 MessageBox.Show("Seleccione un producto para eliminar");
       			 return;
    		}

   				 lvDetalle.Items.Remove(lvDetalle.SelectedItems[0]);
   				 CalcularSubtotal();
			}
        
        void CalcularImporteNeto()
{
    decimal subtotal = 0;
    decimal descuentoPorcentaje = 0;

    decimal.TryParse(txtSubtotal.Text, out subtotal);
    decimal.TryParse(txtDescuento.Text, out descuentoPorcentaje);

    decimal descuento = subtotal * (descuentoPorcentaje / 100);
    decimal importeNeto = subtotal - descuento;

    if (importeNeto < 0)
        importeNeto = 0;

    txtNeto.Text = importeNeto.ToString("0.00");

    CalcularCambio();
}


        void CalcularCambio()
{
    decimal importeNeto = 0;
    decimal importePagado = 0;

    decimal.TryParse(txtNeto.Text, out importeNeto);
    decimal.TryParse(txtPagado.Text, out importePagado);

    decimal cambio = importePagado - importeNeto;

    if (cambio < 0)
        cambio = 0;

    txtCambio.Text = cambio.ToString("0.00");
}

        private void txtDescuentoTextChanged(object sender, EventArgs e)
{
    CalcularImporteNeto();
}

        private void txtImportePagadoTextChanged(object sender, EventArgs e)
{
    CalcularCambio();
}
        
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
{
    Font font = new Font("Consolas", 10);
    float y = 10;
    float lineHeight = font.GetHeight() + 5;

    e.Graphics.DrawString("POSTRES - TICKET", new Font("Consolas", 12, FontStyle.Bold),
        Brushes.Black, 10, y);
    y += lineHeight * 2;

    e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString(), font, Brushes.Black, 10, y);
    y += lineHeight * 2;

    e.Graphics.DrawString("Producto        Cant  Precio  Total", font, Brushes.Black, 10, y);
    y += lineHeight;

    e.Graphics.DrawString("--------------------------------------", font, Brushes.Black, 10, y);
    y += lineHeight;

    foreach (ListViewItem item in lvDetalle.Items)
    {
        string linea =
            item.SubItems[0].Text.PadRight(15) + " " +
            item.SubItems[2].Text.PadRight(5) + " " +
            item.SubItems[1].Text.PadRight(7) + " " +
            item.SubItems[3].Text;

        e.Graphics.DrawString(linea, font, Brushes.Black, 10, y);
        y += lineHeight;
    }

    y += lineHeight;
    e.Graphics.DrawString("--------------------------------------", font, Brushes.Black, 10, y);
    y += lineHeight;

    e.Graphics.DrawString("Subtotal: $" + txtSubtotal.Text, font, Brushes.Black, 10, y);
    y += lineHeight;

    e.Graphics.DrawString("Descuento: $" + txtDescuento.Text, font, Brushes.Black, 10, y);
    y += lineHeight;

    e.Graphics.DrawString("Importe Neto: $" + txtNeto.Text, font, Brushes.Black, 10, y);
    y += lineHeight;

    e.Graphics.DrawString("Pagado: $" + txtPagado.Text, font, Brushes.Black, 10, y);
    y += lineHeight;

    e.Graphics.DrawString("Cambio: $" + txtCambio.Text, font, Brushes.Black, 10, y);
    y += lineHeight * 2;

    e.Graphics.DrawString("¡Gracias por su compra!", font, Brushes.Black, 10, y);
}


		
		void Button3Click(object sender, EventArgs e)
		{
		if (lvDetalle.Items.Count == 0)
    	{
        	MessageBox.Show("No hay productos para imprimir");
        	return;
    	}

    		PrintDialog dialog = new PrintDialog();
    		dialog.Document = printDocument;

    	if (dialog.ShowDialog() == DialogResult.OK)
    	{
        	printDocument.Print();
    	}			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			lvDetalle.Items.Clear();

    txtSubtotal.Clear();
    txtDescuento.Clear();
    txtNeto.Clear();
    txtPagado.Clear();
    txtCambio.Clear();

    LimpiarProducto();			
		}
		
		
		
    }
}
