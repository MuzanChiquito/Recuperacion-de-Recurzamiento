/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 14/12/2025
 * Time: 11:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmPerimetros.
	/// </summary>
	public partial class FrmPerimetros : Form
	{
		public FrmPerimetros()
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
    double radio = double.Parse(txtRadio.Text);
    double perimetro = 2 * Math.PI * radio;
    lblResultado.Text = "Perímetro: " + perimetro.ToString("0.00");
}
			
		
	}
}
