/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 15/12/2025
 * Time: 01:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinal
{
	partial class FrmPrincipal1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.perimetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.volumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convercionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.postresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aplicacionesToolStripMenuItem,
									this.archivoToolStripMenuItem,
									this.acercaDeToolStripMenuItem,
									this.areaToolStripMenuItem,
									this.convercionesToolStripMenuItem,
									this.boletaToolStripMenuItem,
									this.empleadosToolStripMenuItem,
									this.postresToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(774, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aplicacionesToolStripMenuItem
			// 
			this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
			this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
			this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
			this.aplicacionesToolStripMenuItem.Click += new System.EventHandler(this.AplicacionesToolStripMenuItemClick);
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
			this.acercaDeToolStripMenuItem.Text = "Acerca de";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// areaToolStripMenuItem
			// 
			this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cuadradoToolStripMenuItem,
									this.perimetroToolStripMenuItem,
									this.volumenToolStripMenuItem});
			this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
			this.areaToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
			this.areaToolStripMenuItem.Text = "Area";
			// 
			// cuadradoToolStripMenuItem
			// 
			this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
			this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
			this.cuadradoToolStripMenuItem.Text = "Cuadrado";
			this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.CuadradoToolStripMenuItemClick);
			// 
			// perimetroToolStripMenuItem
			// 
			this.perimetroToolStripMenuItem.Name = "perimetroToolStripMenuItem";
			this.perimetroToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
			this.perimetroToolStripMenuItem.Text = "Perimetro";
			this.perimetroToolStripMenuItem.Click += new System.EventHandler(this.PerimetroToolStripMenuItemClick);
			// 
			// volumenToolStripMenuItem
			// 
			this.volumenToolStripMenuItem.Name = "volumenToolStripMenuItem";
			this.volumenToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
			this.volumenToolStripMenuItem.Text = "Volumen";
			this.volumenToolStripMenuItem.Click += new System.EventHandler(this.VolumenToolStripMenuItemClick);
			// 
			// convercionesToolStripMenuItem
			// 
			this.convercionesToolStripMenuItem.Name = "convercionesToolStripMenuItem";
			this.convercionesToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
			this.convercionesToolStripMenuItem.Text = "Converciones";
			this.convercionesToolStripMenuItem.Click += new System.EventHandler(this.ConvercionesToolStripMenuItemClick);
			// 
			// boletaToolStripMenuItem
			// 
			this.boletaToolStripMenuItem.Name = "boletaToolStripMenuItem";
			this.boletaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
			this.boletaToolStripMenuItem.Text = "Boleta";
			this.boletaToolStripMenuItem.Click += new System.EventHandler(this.BoletaToolStripMenuItemClick);
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItemClick);
			// 
			// postresToolStripMenuItem
			// 
			this.postresToolStripMenuItem.Name = "postresToolStripMenuItem";
			this.postresToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.postresToolStripMenuItem.Text = "Postres";
			this.postresToolStripMenuItem.Click += new System.EventHandler(this.PostresToolStripMenuItemClick);
			// 
			// FrmPrincipal1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 422);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmPrincipal1";
			this.Text = "Formulario Principal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem postresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem boletaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem convercionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem volumenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem perimetroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
