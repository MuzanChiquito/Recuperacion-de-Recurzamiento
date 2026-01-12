/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 14/12/2025
 * Time: 10:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmAreas.
	/// </summary>
	public partial class FrmAreas : Form
	{
		public FrmAreas()
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
    double area = lado * lado;
    lblResultado.Text = "Área: " + area;
}
			
		
	}
}
