/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 15/12/2025
 * Time: 03:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinal
{
	partial class FrmPostres
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPostres));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.RbSalados = new System.Windows.Forms.RadioButton();
			this.rbDulces = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.cboProductos = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.lvDetalle = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNeto = new System.Windows.Forms.TextBox();
			this.txtPagado = new System.Windows.Forms.TextBox();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(713, 159);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RbSalados);
			this.groupBox1.Controls.Add(this.rbDulces);
			this.groupBox1.Location = new System.Drawing.Point(247, 165);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 59);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de producto";
			// 
			// RbSalados
			// 
			this.RbSalados.Checked = true;
			this.RbSalados.ForeColor = System.Drawing.Color.Green;
			this.RbSalados.Location = new System.Drawing.Point(90, 21);
			this.RbSalados.Name = "RbSalados";
			this.RbSalados.Size = new System.Drawing.Size(104, 24);
			this.RbSalados.TabIndex = 1;
			this.RbSalados.TabStop = true;
			this.RbSalados.Text = "Salados";
			this.RbSalados.UseVisualStyleBackColor = true;
			this.RbSalados.CheckedChanged += new System.EventHandler(this.RbSaladosCheckedChanged);
			// 
			// rbDulces
			// 
			this.rbDulces.ForeColor = System.Drawing.Color.Red;
			this.rbDulces.Location = new System.Drawing.Point(6, 21);
			this.rbDulces.Name = "rbDulces";
			this.rbDulces.Size = new System.Drawing.Size(78, 24);
			this.rbDulces.TabIndex = 0;
			this.rbDulces.Text = "Dulces";
			this.rbDulces.UseVisualStyleBackColor = true;
			this.rbDulces.CheckedChanged += new System.EventHandler(this.rbDulcesCheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 230);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Seleccionar producto:";
			// 
			// cboProductos
			// 
			this.cboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProductos.FormattingEnabled = true;
			this.cboProductos.Location = new System.Drawing.Point(184, 230);
			this.cboProductos.Name = "cboProductos";
			this.cboProductos.Size = new System.Drawing.Size(303, 24);
			this.cboProductos.TabIndex = 3;
			this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductosSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(35, 276);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Precio";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(169, 276);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Cantidad";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(299, 276);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Total";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(35, 302);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.ReadOnly = true;
			this.txtPrecio.Size = new System.Drawing.Size(100, 22);
			this.txtPrecio.TabIndex = 7;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(169, 302);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 22);
			this.txtCantidad.TabIndex = 8;
			this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidadTextChanged);
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(299, 302);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(100, 22);
			this.txtTotal.TabIndex = 9;
			// 
			// btnAgregar
			// 
			this.btnAgregar.ForeColor = System.Drawing.Color.LightGreen;
			this.btnAgregar.Location = new System.Drawing.Point(535, 223);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(141, 37);
			this.btnAgregar.TabIndex = 10;
			this.btnAgregar.Text = "Agregar Producto";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.ForeColor = System.Drawing.Color.LightCoral;
			this.btnEliminar.Location = new System.Drawing.Point(535, 266);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(141, 37);
			this.btnEliminar.TabIndex = 11;
			this.btnEliminar.Text = "Eliminar Producto";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// lvDetalle
			// 
			this.lvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4});
			this.lvDetalle.FullRowSelect = true;
			this.lvDetalle.GridLines = true;
			this.lvDetalle.Location = new System.Drawing.Point(35, 341);
			this.lvDetalle.Name = "lvDetalle";
			this.lvDetalle.Size = new System.Drawing.Size(641, 130);
			this.lvDetalle.TabIndex = 12;
			this.lvDetalle.UseCompatibleStateImageBehavior = false;
			this.lvDetalle.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Producto";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Precio";
			this.columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Cantidad";
			this.columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Total";
			this.columnHeader4.Width = 80;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(35, 497);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "SubTotal:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(247, 496);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "Descuento:";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(115, 497);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
			this.txtSubtotal.TabIndex = 15;
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(337, 496);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(100, 22);
			this.txtDescuento.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(496, 495);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "Importe Neto:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(473, 528);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(123, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Importe Pagado:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(496, 563);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Cambio:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtNeto
			// 
			this.txtNeto.Location = new System.Drawing.Point(602, 495);
			this.txtNeto.Name = "txtNeto";
			this.txtNeto.Size = new System.Drawing.Size(100, 22);
			this.txtNeto.TabIndex = 20;
			// 
			// txtPagado
			// 
			this.txtPagado.Location = new System.Drawing.Point(602, 529);
			this.txtPagado.Name = "txtPagado";
			this.txtPagado.Size = new System.Drawing.Size(100, 22);
			this.txtPagado.TabIndex = 21;
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(602, 564);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(100, 22);
			this.txtCambio.TabIndex = 22;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(45, 552);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(90, 34);
			this.btnGuardar.TabIndex = 23;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(141, 552);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 34);
			this.button2.TabIndex = 24;
			this.button2.Text = "Borrar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(272, 552);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 34);
			this.button3.TabIndex = 25;
			this.button3.Text = "Imprimir";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// FrmPostres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(713, 647);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.txtPagado);
			this.Controls.Add(this.txtNeto);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lvDetalle);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboProductos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmPostres";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bocaditos Delicados";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.TextBox txtPagado;
		private System.Windows.Forms.TextBox txtNeto;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvDetalle;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboProductos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbDulces;
		private System.Windows.Forms.RadioButton RbSalados;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
