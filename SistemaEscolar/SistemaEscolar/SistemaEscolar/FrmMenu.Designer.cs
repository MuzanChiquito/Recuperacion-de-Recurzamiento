/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 11/01/2026
 * Time: 09:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SistemaEscolar
{
	partial class FrmMenu
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
			this.btnAlumnos = new System.Windows.Forms.Button();
			this.btnPromedio = new System.Windows.Forms.Button();
			this.btnNumeros = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAlumnos
			// 
			this.btnAlumnos.Location = new System.Drawing.Point(78, 86);
			this.btnAlumnos.Name = "btnAlumnos";
			this.btnAlumnos.Size = new System.Drawing.Size(157, 31);
			this.btnAlumnos.TabIndex = 0;
			this.btnAlumnos.Text = "Registro de Alumnos";
			this.btnAlumnos.UseVisualStyleBackColor = true;
			this.btnAlumnos.Click += new System.EventHandler(this.BtnAlumnosClick);
			// 
			// btnPromedio
			// 
			this.btnPromedio.Location = new System.Drawing.Point(241, 86);
			this.btnPromedio.Name = "btnPromedio";
			this.btnPromedio.Size = new System.Drawing.Size(157, 31);
			this.btnPromedio.TabIndex = 1;
			this.btnPromedio.Text = "Promedio";
			this.btnPromedio.UseVisualStyleBackColor = true;
			this.btnPromedio.Click += new System.EventHandler(this.BtnPromedioClick);
			// 
			// btnNumeros
			// 
			this.btnNumeros.Location = new System.Drawing.Point(78, 123);
			this.btnNumeros.Name = "btnNumeros";
			this.btnNumeros.Size = new System.Drawing.Size(157, 31);
			this.btnNumeros.TabIndex = 2;
			this.btnNumeros.Text = "Números";
			this.btnNumeros.UseVisualStyleBackColor = true;
			this.btnNumeros.Click += new System.EventHandler(this.BtnNumerosClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(241, 123);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(157, 31);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(185, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 32);
			this.label1.TabIndex = 4;
			this.label1.Text = "Menu";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 253);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnNumeros);
			this.Controls.Add(this.btnPromedio);
			this.Controls.Add(this.btnAlumnos);
			this.Name = "FrmMenu";
			this.Text = "FrmMenu";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnNumeros;
		private System.Windows.Forms.Button btnPromedio;
		private System.Windows.Forms.Button btnAlumnos;
	}
}
