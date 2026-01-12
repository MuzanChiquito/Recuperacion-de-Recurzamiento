/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 15/12/2025
 * Time: 08:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmAcercaDe.
	/// </summary>
	public partial class FrmAcercaDe : Form
	{
		public FrmAcercaDe()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
