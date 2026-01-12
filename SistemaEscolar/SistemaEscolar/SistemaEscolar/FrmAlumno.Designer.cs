/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 11/01/2026
 * Time: 09:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SistemaEscolar
{
	partial class FrmAlumno
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.txtMatricula = new System.Windows.Forms.TextBox();
			this.txtCarrera = new System.Windows.Forms.TextBox();
			this.txtSemestre = new System.Windows.Forms.TextBox();
			this.txtGrupo = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(134, 16);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 22);
			this.txtNombre.TabIndex = 0;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(134, 44);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(100, 22);
			this.txtApellido.TabIndex = 1;
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(134, 72);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(100, 22);
			this.txtEdad.TabIndex = 2;
			// 
			// txtMatricula
			// 
			this.txtMatricula.Location = new System.Drawing.Point(134, 100);
			this.txtMatricula.Name = "txtMatricula";
			this.txtMatricula.Size = new System.Drawing.Size(100, 22);
			this.txtMatricula.TabIndex = 3;
			// 
			// txtCarrera
			// 
			this.txtCarrera.Location = new System.Drawing.Point(134, 128);
			this.txtCarrera.Name = "txtCarrera";
			this.txtCarrera.Size = new System.Drawing.Size(100, 22);
			this.txtCarrera.TabIndex = 4;
			// 
			// txtSemestre
			// 
			this.txtSemestre.Location = new System.Drawing.Point(134, 156);
			this.txtSemestre.Name = "txtSemestre";
			this.txtSemestre.Size = new System.Drawing.Size(100, 22);
			this.txtSemestre.TabIndex = 5;
			// 
			// txtGrupo
			// 
			this.txtGrupo.Location = new System.Drawing.Point(134, 184);
			this.txtGrupo.Name = "txtGrupo";
			this.txtGrupo.Size = new System.Drawing.Size(100, 22);
			this.txtGrupo.TabIndex = 6;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(134, 212);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(100, 22);
			this.txtTelefono.TabIndex = 7;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(134, 240);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(100, 22);
			this.txtCorreo.TabIndex = 8;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(134, 268);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(100, 22);
			this.txtDireccion.TabIndex = 9;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(134, 306);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(100, 30);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 22);
			this.label1.TabIndex = 11;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(28, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 22);
			this.label2.TabIndex = 12;
			this.label2.Text = "Apellido";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(28, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 13;
			this.label3.Text = "Edad";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(28, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 22);
			this.label4.TabIndex = 14;
			this.label4.Text = "Matricula";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(28, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 22);
			this.label5.TabIndex = 15;
			this.label5.Text = "Carrera ";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(28, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 22);
			this.label6.TabIndex = 16;
			this.label6.Text = "Semestre";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(28, 184);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 22);
			this.label7.TabIndex = 17;
			this.label7.Text = "Grupo";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(28, 212);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 22);
			this.label8.TabIndex = 18;
			this.label8.Text = "Telefono";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(28, 240);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 22);
			this.label9.TabIndex = 19;
			this.label9.Text = "Correo";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(28, 268);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 22);
			this.label10.TabIndex = 20;
			this.label10.Text = "Direccion";
			// 
			// FrmAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 374);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtGrupo);
			this.Controls.Add(this.txtSemestre);
			this.Controls.Add(this.txtCarrera);
			this.Controls.Add(this.txtMatricula);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Name = "FrmAlumno";
			this.Text = "FrmAlumno";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtGrupo;
		private System.Windows.Forms.TextBox txtSemestre;
		private System.Windows.Forms.TextBox txtCarrera;
		private System.Windows.Forms.TextBox txtMatricula;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
	}
}
