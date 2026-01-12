/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 14/12/2025
 * Time: 10:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinal
{
	partial class FrmFactorialFibonacci
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
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnFactorial = new System.Windows.Forms.Button();
			this.btnFibonacci = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Número";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(27, 66);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 22);
			this.txtNumero.TabIndex = 1;
			// 
			// btnFactorial
			// 
			this.btnFactorial.Location = new System.Drawing.Point(151, 34);
			this.btnFactorial.Name = "btnFactorial";
			this.btnFactorial.Size = new System.Drawing.Size(86, 29);
			this.btnFactorial.TabIndex = 2;
			this.btnFactorial.Text = "Factorial";
			this.btnFactorial.UseVisualStyleBackColor = true;
			this.btnFactorial.Click += new System.EventHandler(this.btnFactorialClick);
			// 
			// btnFibonacci
			// 
			this.btnFibonacci.Location = new System.Drawing.Point(151, 69);
			this.btnFibonacci.Name = "btnFibonacci";
			this.btnFibonacci.Size = new System.Drawing.Size(86, 28);
			this.btnFibonacci.TabIndex = 3;
			this.btnFibonacci.Text = "Fibonacci";
			this.btnFibonacci.UseVisualStyleBackColor = true;
			this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacciClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(27, 107);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 4;
			this.lblResultado.Text = "Resultado";
			// 
			// FrmFactorialFibonacci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnFibonacci);
			this.Controls.Add(this.btnFactorial);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label1);
			this.Name = "FrmFactorialFibonacci";
			this.Text = "FrmFactorialFibonacci";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnFibonacci;
		private System.Windows.Forms.Button btnFactorial;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label1;
	}
}
