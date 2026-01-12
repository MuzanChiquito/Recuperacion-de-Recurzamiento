/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 15/12/2025
 * Time: 12:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinal
{
	partial class FrmBoleta
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
			this.txtMateria = new System.Windows.Forms.TextBox();
			this.txtParcial1 = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAlumno = new System.Windows.Forms.TextBox();
			this.txtParcial2 = new System.Windows.Forms.TextBox();
			this.txtParcial3 = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Materia";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Parcial 1";
			// 
			// txtMateria
			// 
			this.txtMateria.Location = new System.Drawing.Point(118, 40);
			this.txtMateria.Name = "txtMateria";
			this.txtMateria.Size = new System.Drawing.Size(100, 22);
			this.txtMateria.TabIndex = 2;
			// 
			// txtParcial1
			// 
			this.txtParcial1.Location = new System.Drawing.Point(118, 68);
			this.txtParcial1.Name = "txtParcial1";
			this.txtParcial1.Size = new System.Drawing.Size(100, 22);
			this.txtParcial1.TabIndex = 3;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(12, 173);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(90, 34);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7,
									this.columnHeader8});
			this.listView1.Location = new System.Drawing.Point(118, 173);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(804, 116);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Alumno";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Materia";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Parcial 1";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Parcial 2";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Parcial 3";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Promedio";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Parcial 2";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Parcial 3";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Alumno";
			// 
			// txtAlumno
			// 
			this.txtAlumno.Location = new System.Drawing.Point(118, 12);
			this.txtAlumno.Name = "txtAlumno";
			this.txtAlumno.Size = new System.Drawing.Size(100, 22);
			this.txtAlumno.TabIndex = 9;
			// 
			// txtParcial2
			// 
			this.txtParcial2.Location = new System.Drawing.Point(118, 96);
			this.txtParcial2.Name = "txtParcial2";
			this.txtParcial2.Size = new System.Drawing.Size(100, 22);
			this.txtParcial2.TabIndex = 10;
			// 
			// txtParcial3
			// 
			this.txtParcial3.Location = new System.Drawing.Point(118, 124);
			this.txtParcial3.Name = "txtParcial3";
			this.txtParcial3.Size = new System.Drawing.Size(100, 22);
			this.txtParcial3.TabIndex = 11;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(12, 213);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(90, 36);
			this.btnEliminar.TabIndex = 12;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// FrmBoleta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 362);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.txtParcial3);
			this.Controls.Add(this.txtParcial2);
			this.Controls.Add(this.txtAlumno);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtParcial1);
			this.Controls.Add(this.txtMateria);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmBoleta";
			this.Text = "FrmBoleta";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox txtParcial3;
		private System.Windows.Forms.TextBox txtParcial2;
		private System.Windows.Forms.TextBox txtAlumno;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtParcial1;
		private System.Windows.Forms.TextBox txtMateria;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
