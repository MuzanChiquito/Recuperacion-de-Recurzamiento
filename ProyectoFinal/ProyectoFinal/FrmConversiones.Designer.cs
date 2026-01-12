/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 14/12/2025
 * Time: 11:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinal
{
	partial class FrmConversiones
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.btnKmMillas = new System.Windows.Forms.Button();
			this.btnKgLibras = new System.Windows.Forms.Button();
			this.btnCF = new System.Windows.Forms.Button();
			this.btnSegHoras = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(135, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Conversiones";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Valor:";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(12, 67);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(100, 22);
			this.txtValor.TabIndex = 2;
			// 
			// btnKmMillas
			// 
			this.btnKmMillas.Location = new System.Drawing.Point(172, 35);
			this.btnKmMillas.Name = "btnKmMillas";
			this.btnKmMillas.Size = new System.Drawing.Size(150, 37);
			this.btnKmMillas.TabIndex = 3;
			this.btnKmMillas.Text = "Km a Millas";
			this.btnKmMillas.UseVisualStyleBackColor = true;
			this.btnKmMillas.Click += new System.EventHandler(this.btnKmMillasClick);
			// 
			// btnKgLibras
			// 
			this.btnKgLibras.Location = new System.Drawing.Point(172, 78);
			this.btnKgLibras.Name = "btnKgLibras";
			this.btnKgLibras.Size = new System.Drawing.Size(150, 38);
			this.btnKgLibras.TabIndex = 4;
			this.btnKgLibras.Text = "Kg a Libras";
			this.btnKgLibras.UseVisualStyleBackColor = true;
			this.btnKgLibras.Click += new System.EventHandler(this.btnKgLibrasClick);
			// 
			// btnCF
			// 
			this.btnCF.Location = new System.Drawing.Point(172, 122);
			this.btnCF.Name = "btnCF";
			this.btnCF.Size = new System.Drawing.Size(150, 40);
			this.btnCF.TabIndex = 5;
			this.btnCF.Text = "Celsius a Fahrenheit";
			this.btnCF.UseVisualStyleBackColor = true;
			this.btnCF.Click += new System.EventHandler(this.btnCFClick);
			// 
			// btnSegHoras
			// 
			this.btnSegHoras.Location = new System.Drawing.Point(172, 168);
			this.btnSegHoras.Name = "btnSegHoras";
			this.btnSegHoras.Size = new System.Drawing.Size(150, 41);
			this.btnSegHoras.TabIndex = 6;
			this.btnSegHoras.Text = "Segundos a Horas";
			this.btnSegHoras.UseVisualStyleBackColor = true;
			this.btnSegHoras.Click += new System.EventHandler(this.btnSegHorasClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(12, 134);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(142, 23);
			this.lblResultado.TabIndex = 7;
			this.lblResultado.Text = "Resultado";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FrmConversiones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 253);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnSegHoras);
			this.Controls.Add(this.btnCF);
			this.Controls.Add(this.btnKgLibras);
			this.Controls.Add(this.btnKmMillas);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmConversiones";
			this.Text = "FrmConversiones";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnSegHoras;
		private System.Windows.Forms.Button btnCF;
		private System.Windows.Forms.Button btnKgLibras;
		private System.Windows.Forms.Button btnKmMillas;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
