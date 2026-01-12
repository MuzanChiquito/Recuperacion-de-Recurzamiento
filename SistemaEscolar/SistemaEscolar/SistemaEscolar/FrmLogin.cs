/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 11/01/2026
 * Time: 09:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscolar
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
		
		void BtnIngresarClick(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "admin" && txtPassword.Text == "1234")
    {
        FrmMenu menu = new FrmMenu();
        menu.Show();
        this.Hide();
    }
    else
    {
        MessageBox.Show("Usuario o contraseña incorrectos");
    }			
		}
	}
}
