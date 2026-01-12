/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 14/12/2025
 * Time: 10:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmFactorialFibonacci.
	/// </summary>
	public partial class FrmFactorialFibonacci : Form
	{
		public FrmFactorialFibonacci()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void btnFactorialClick(object sender, EventArgs e)
{
    int n = int.Parse(txtNumero.Text);
    int factorial = 1;

    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }

    lblResultado.Text = "Factorial: " + factorial;
}

		
		private void btnFibonacciClick(object sender, EventArgs e)
{
    int a = 0, b = 1;
    string serie = "0 1 ";

    for (int i = 2; i < 10; i++)
    {
        int c = a + b;
        serie += c + " ";
        a = b;
        b = c;
    }

    lblResultado.Text = "Fibonacci: " + serie;
}

	}
}
