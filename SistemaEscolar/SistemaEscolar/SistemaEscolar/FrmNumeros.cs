/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 11/01/2026
 * Time: 10:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscolar
{
	/// <summary>
	/// Description of FrmNumeros.
	/// </summary>
	public partial class FrmNumeros : Form
	{
		public FrmNumeros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		int[] numeros = new int[10];
		void BtnGenerarClick(object sender, EventArgs e)
		{
			Random r = new Random();
    		listBox1.Items.Clear();

    		for (int i = 0; i < 10; i++)
    		{
        		numeros[i] = r.Next(1, 100);
        		listBox1.Items.Add(numeros[i]);
    		}
		}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
			Array.Sort(numeros);
    		listBox1.Items.Clear();

    		foreach (int n in numeros)
        		listBox1.Items.Add(n);			
		}
	}
}
