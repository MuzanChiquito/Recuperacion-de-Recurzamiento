/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 11/01/2026
 * Time: 09:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SistemaEscolar
{
	partial class FrmDatosAlumno
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
			this.lblDatos = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDatos
			// 
			this.lblDatos.Location = new System.Drawing.Point(56, 23);
			this.lblDatos.Name = "lblDatos";
			this.lblDatos.Size = new System.Drawing.Size(165, 211);
			this.lblDatos.TabIndex = 0;
			this.lblDatos.Text = "label1";
			// 
			// FrmDatosAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Controls.Add(this.lblDatos);
			this.Name = "FrmDatosAlumno";
			this.Text = "FrmDatosAlumno";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblDatos;
	}
}
