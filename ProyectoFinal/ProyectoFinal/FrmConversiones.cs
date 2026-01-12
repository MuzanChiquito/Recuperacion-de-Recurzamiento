/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 14/12/2025
 * Time: 11:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmConversiones.
	/// </summary>
	public partial class FrmConversiones : Form
	{
		public FrmConversiones()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
private void btnKmMillasClick(object sender, EventArgs e)
{
    double km = double.Parse(txtValor.Text);
    double millas = km * 0.621371;
    lblResultado.Text = "Millas: " + millas.ToString("0.00");
}
			
		
		
		
private void btnKgLibrasClick(object sender, EventArgs e)
{
    double kg = double.Parse(txtValor.Text);
    double libras = kg * 2.20462;
    lblResultado.Text = "Libras: " + libras.ToString("0.00");
}
			
		
		
private void btnCFClick(object sender, EventArgs e)
{
    double c = double.Parse(txtValor.Text);
    double f = (c * 9 / 5) + 32;
    lblResultado.Text = "Fahrenheit: " + f;
}
			
		
		
		
private void btnSegHorasClick(object sender, EventArgs e)
{
    double s = double.Parse(txtValor.Text);
    double horas = s / 3600;
    lblResultado.Text = "Horas: " + horas.ToString("0.000");
}
			
		
	}
}
