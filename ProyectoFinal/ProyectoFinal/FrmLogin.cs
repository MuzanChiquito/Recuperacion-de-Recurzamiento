/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 14/12/2025
 * Time: 09:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmLogin.
	/// </summary>
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		int intentos = 0;
private void BtnIngresarClick(object sender, EventArgs e)
{
    if (txtUsuario.Text == "admin" && txtPassword.Text == "1234")
    {
        FrmPrincipal1 p = new FrmPrincipal1();
        p.Show();
        this.Hide();
    }
    else
    {
        intentos++;
        MessageBox.Show("Usuario o contraseña incorrectos");

        if (intentos == 3)
        {
            MessageBox.Show("Intentos agotados");
            Application.Exit();
        }
    }
}
			
		}
	}

