using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscolar
{
	/// <summary>
	/// Description of FrmMenu.
	/// </summary>
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAlumnosClick(object sender, EventArgs e)
		{
			FrmAlumno f = new FrmAlumno();
    		f.Show();			
		}
		
		void BtnPromedioClick(object sender, EventArgs e)
		{
			FrmPromedio f = new FrmPromedio();
    		f.Show();			
		}
		
		void BtnNumerosClick(object sender, EventArgs e)
		{
			FrmNumeros f = new FrmNumeros();
    		f.Show();			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();			
		}
	}
}
