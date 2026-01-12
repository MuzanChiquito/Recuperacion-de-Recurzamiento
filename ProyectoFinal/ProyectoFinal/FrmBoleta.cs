using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmBoleta.
	/// </summary>
	public partial class FrmBoleta : Form
	{
		MySqlConnection conexion = new MySqlConnection(
    		"Server=localhost;Database=dbBoleta;Uid=root;Pwd=;"
		);

		public FrmBoleta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
				listView1.View = View.Details;
				listView1.FullRowSelect = true;
				listView1.GridLines = true;
				listView1.UseCompatibleStateImageBehavior = false;
				
				listView1.Columns.Clear();

				listView1.Columns.Add("Alumno", 120);
				listView1.Columns.Add("Materia", 120);
				listView1.Columns.Add("Parcial 1", 80);
				listView1.Columns.Add("Parcial 2", 80);
				listView1.Columns.Add("Parcial 3", 80);
				listView1.Columns.Add("Promedio", 80);

			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if (txtAlumno.Text == "" || txtMateria.Text == "" ||
        txtParcial1.Text == "" || txtParcial2.Text == "" || txtParcial3.Text == "")
    {
        MessageBox.Show("Llene todos los campos");
        return;
    }

    double p1, p2, p3;

    if (!double.TryParse(txtParcial1.Text, out p1) ||
        !double.TryParse(txtParcial2.Text, out p2) ||
        !double.TryParse(txtParcial3.Text, out p3))
    {
        MessageBox.Show("Las calificaciones deben ser números");
        return;
    }

    double promedio = (p1 + p2 + p3) / 3;

    // 🔹 GUARDAR EN BD
    string sql = "INSERT INTO calificaciones " +
        "(alumno, materia, parcial1, parcial2, parcial3, promedio) " +
        "VALUES (@a,@m,@p1,@p2,@p3,@pr); SELECT LAST_INSERT_ID();";

    MySqlCommand cmd = new MySqlCommand(sql, conexion);
    cmd.Parameters.AddWithValue("@a", txtAlumno.Text);
    cmd.Parameters.AddWithValue("@m", txtMateria.Text);
    cmd.Parameters.AddWithValue("@p1", p1);
    cmd.Parameters.AddWithValue("@p2", p2);
    cmd.Parameters.AddWithValue("@p3", p3);
    cmd.Parameters.AddWithValue("@pr", promedio);

    conexion.Open();
    int id = Convert.ToInt32(cmd.ExecuteScalar());
    conexion.Close();

    // 🔹 AGREGAR AL LISTVIEW
    ListViewItem item = new ListViewItem(txtAlumno.Text);
    item.Tag = id;
    item.SubItems.Add(txtMateria.Text);
    item.SubItems.Add(p1.ToString());
    item.SubItems.Add(p2.ToString());
    item.SubItems.Add(p3.ToString());
    item.SubItems.Add(promedio.ToString("0.00"));

    listView1.Items.Add(item);

    // 🔹 AHORA SÍ limpiar campos
    txtAlumno.Clear();
    txtMateria.Clear();
    txtParcial1.Clear();
    txtParcial2.Clear();
    txtParcial3.Clear();
    txtAlumno.Focus();
    		
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0)
    		{
        		MessageBox.Show("Seleccione un registro");
        		return;
    		}

    		ListViewItem item = listView1.SelectedItems[0];
    		int id = (int)item.Tag;

    		DialogResult r = MessageBox.Show(
        		"¿Seguro que desea eliminar este registro?",
        		"Confirmar",
        		MessageBoxButtons.YesNo,
        		MessageBoxIcon.Question
    		);

    		if (r == DialogResult.No)
        		return;

    		string sql = "DELETE FROM calificaciones WHERE id=@id";
    		MySqlCommand cmd = new MySqlCommand(sql, conexion);
    		cmd.Parameters.AddWithValue("@id", id);

    		try
    		{
        		conexion.Open();
        		cmd.ExecuteNonQuery();
        		conexion.Close();

        		listView1.Items.Remove(item);
    		}
    		catch (Exception ex)
    		{
        		MessageBox.Show("Error al eliminar: " + ex.Message);
    		}			
		}
	}
}
