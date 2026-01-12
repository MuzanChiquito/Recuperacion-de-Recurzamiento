/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 15/12/2025
 * Time: 01:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmPrincipal1.
	/// </summary>
	public partial class FrmPrincipal1 : Form
	{
		public FrmPrincipal1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
if (MessageBox.Show("¿Desea salir?", "Salir",
    MessageBoxButtons.YesNo) == DialogResult.Yes)
{
    Application.Exit();
}
			
		}
		
		void AplicacionesToolStripMenuItemClick(object sender, EventArgs e)
		{
FrmFactorialFibonacci f = new FrmFactorialFibonacci();
    f.MdiParent = this;
    f.Show();			
		}
		
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
FrmAreas a = new FrmAreas();
a.MdiParent = this;
a.Show();
			
		}
		
		void PerimetroToolStripMenuItemClick(object sender, EventArgs e)
		{
FrmPerimetros p = new FrmPerimetros();
p.MdiParent = this;
p.Show();
			
		}
		
		void VolumenToolStripMenuItemClick(object sender, EventArgs e)
		{
FrmVolumen v = new FrmVolumen();
v.MdiParent = this;
v.Show();
			
		}
		
		void ConvercionesToolStripMenuItemClick(object sender, EventArgs e)
		{
FrmConversiones c = new FrmConversiones();
    c.MdiParent = this;
    c.Show();			
		}
		
		void BoletaToolStripMenuItemClick(object sender, EventArgs e)
		{
 FrmBoleta b = new FrmBoleta();
    b.MdiParent = this;
    b.Show();			
		}
		
		void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
FrmEmpleados e1 = new FrmEmpleados();
    e1.MdiParent = this;
    e1.Show();			
		}
		
		void PostresToolStripMenuItemClick(object sender, EventArgs e)
		{
FrmPostres e1 = new FrmPostres();
    e1.MdiParent = this;
    e1.Show();			
		}
		
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
FrmAcercaDe Ac1 = new FrmAcercaDe();
    Ac1.MdiParent = this;
    Ac1.Show();			
		}
	}
}


