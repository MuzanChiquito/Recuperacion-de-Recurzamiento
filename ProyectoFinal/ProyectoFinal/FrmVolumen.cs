/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 14/12/2025
 * Time: 11:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmVolumen.
	/// </summary>
	public partial class FrmVolumen : Form
	{
		public FrmVolumen()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

private void BtnCalcularClick(object sender, EventArgs e)
{
    double lado = double.Parse(txtLado.Text);
    double volumen = lado * lado * lado;
    lblResultado.Text = "Volumen: " + volumen;
}
			
		
	}
}
