/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 11/01/2026
 * Time: 09:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscolar
{
	/// <summary>
	/// Description of FrmAlumno.
	/// </summary>
	public partial class FrmAlumno : Form
	{
		public FrmAlumno()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			FrmDatosAlumno datos = new FrmDatosAlumno(
        	txtNombre.Text,
        	txtApellido.Text,
        	txtEdad.Text,
        	txtMatricula.Text,
        	txtCarrera.Text,
        	txtSemestre.Text,
        	txtGrupo.Text,
        	txtTelefono.Text,
        	txtCorreo.Text,
        	txtDireccion.Text
    	);
    	datos.Show();			
		}
	}
}
