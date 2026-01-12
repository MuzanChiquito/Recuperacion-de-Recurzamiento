/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 11/01/2026
 * Time: 09:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscolar
{
	/// <summary>
	/// Description of FrmPromedio.
	/// </summary>
	public partial class FrmPromedio : Form
	{
		public FrmPromedio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
				double suma =
        	Convert.ToDouble(txt1.Text) +
        	Convert.ToDouble(txt2.Text) +
        	Convert.ToDouble(txt3.Text);
        	
    	double promedio = suma / 3;
    	lblResultado.Text = "Promedio: " + promedio;			
		}
		
	}
}
