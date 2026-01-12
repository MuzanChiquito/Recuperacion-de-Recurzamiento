using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmEmpleados.
	/// </summary>
	public partial class FrmEmpleados : Form
	{
		public FrmEmpleados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		MySqlConnection con = new MySqlConnection(
    "server=localhost;database=proyecto_final;uid=root;pwd=;");


		
		
		


void CargarEmpleados()
{
    MySqlDataAdapter da = new MySqlDataAdapter(
        "SELECT * FROM empleados", con);

    DataTable dt = new DataTable();
    da.Fill(dt);

    dataGridView1.DataSource = dt;
}

private void FrmEmpleadosLoad(object sender, EventArgs e)
{
    CargarEmpleados();
}



			
		
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
if (dataGridView1.SelectedRows.Count == 0)
    {
        MessageBox.Show("Seleccione un registro");
        return;
    }

    int id = Convert.ToInt32(
        dataGridView1.SelectedRows[0].Cells["id"].Value);

    con.Open();

    MySqlCommand cmd = new MySqlCommand(
        "DELETE FROM empleados WHERE id=@id", con);

    cmd.Parameters.AddWithValue("@id", id);
    cmd.ExecuteNonQuery();

    con.Close();

    CargarEmpleados();			
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
if (txtNombre.Text == "" || txtPuesto.Text == "" || txtSueldo.Text == "")
    {
        MessageBox.Show("Complete todos los campos");
        return;
    }

    con.Open();

    MySqlCommand cmd = new MySqlCommand(
        "INSERT INTO empleados (nombre, puesto, sueldo) VALUES (@n, @p, @s)", con);

    cmd.Parameters.AddWithValue("@n", txtNombre.Text);
    cmd.Parameters.AddWithValue("@p", txtPuesto.Text);
    cmd.Parameters.AddWithValue("@s", txtSueldo.Text);

    cmd.ExecuteNonQuery();
    con.Close();

    CargarEmpleados();

    txtNombre.Clear();
    txtPuesto.Clear();
    txtSueldo.Clear();			
		}
	}
}
