
namespace ProductosApp.Formularios
{
	partial class FrmMetodos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtbProductos = new System.Windows.Forms.RichTextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.gbCompras = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.gbVentas = new System.Windows.Forms.GroupBox();
			this.lblLotes = new System.Windows.Forms.Label();
			this.txtLotes = new System.Windows.Forms.TextBox();
			this.btnLotes = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.gbCompras.SuspendLayout();
			this.gbVentas.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbProductos
			// 
			this.rtbProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbProductos.Location = new System.Drawing.Point(12, 83);
			this.rtbProductos.Name = "rtbProductos";
			this.rtbProductos.ReadOnly = true;
			this.rtbProductos.Size = new System.Drawing.Size(711, 355);
			this.rtbProductos.TabIndex = 0;
			this.rtbProductos.Text = "";
			this.rtbProductos.TextChanged += new System.EventHandler(this.rtbProductos_TextChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Vender",
            "Comprar"});
			this.comboBox1.Location = new System.Drawing.Point(37, 44);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// gbCompras
			// 
			this.gbCompras.Controls.Add(this.btnEnviar);
			this.gbCompras.Controls.Add(this.dtpFechaCompra);
			this.gbCompras.Controls.Add(this.txtPrecio);
			this.gbCompras.Controls.Add(this.txtUnidad);
			this.gbCompras.Controls.Add(this.label3);
			this.gbCompras.Controls.Add(this.label2);
			this.gbCompras.Controls.Add(this.label1);
			this.gbCompras.Location = new System.Drawing.Point(223, 12);
			this.gbCompras.Name = "gbCompras";
			this.gbCompras.Size = new System.Drawing.Size(565, 65);
			this.gbCompras.TabIndex = 2;
			this.gbCompras.TabStop = false;
			this.gbCompras.Text = "Compras";
			this.gbCompras.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Unidad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(166, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Precio: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(337, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fecha de Compra:";
			// 
			// txtUnidad
			// 
			this.txtUnidad.Location = new System.Drawing.Point(0, 39);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(100, 20);
			this.txtUnidad.TabIndex = 3;
			this.txtUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidad_KeyPress);
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(169, 38);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(61, 20);
			this.txtPrecio.TabIndex = 4;
			this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
			// 
			// dtpFechaCompra
			// 
			this.dtpFechaCompra.Location = new System.Drawing.Point(307, 36);
			this.dtpFechaCompra.Name = "dtpFechaCompra";
			this.dtpFechaCompra.Size = new System.Drawing.Size(148, 20);
			this.dtpFechaCompra.TabIndex = 5;
			// 
			// btnEnviar
			// 
			this.btnEnviar.Location = new System.Drawing.Point(484, 30);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(75, 23);
			this.btnEnviar.TabIndex = 6;
			this.btnEnviar.Text = "Comprar ";
			this.btnEnviar.UseVisualStyleBackColor = true;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// gbVentas
			// 
			this.gbVentas.Controls.Add(this.btnLotes);
			this.gbVentas.Controls.Add(this.txtLotes);
			this.gbVentas.Controls.Add(this.lblLotes);
			this.gbVentas.Location = new System.Drawing.Point(217, 12);
			this.gbVentas.Name = "gbVentas";
			this.gbVentas.Size = new System.Drawing.Size(565, 59);
			this.gbVentas.TabIndex = 3;
			this.gbVentas.TabStop = false;
			this.gbVentas.Text = "Ventas";
			this.gbVentas.Visible = false;
			// 
			// lblLotes
			// 
			this.lblLotes.AutoSize = true;
			this.lblLotes.Location = new System.Drawing.Point(103, 15);
			this.lblLotes.Name = "lblLotes";
			this.lblLotes.Size = new System.Drawing.Size(109, 13);
			this.lblLotes.TabIndex = 0;
			this.lblLotes.Text = "EsperandoRespuesta";
			this.lblLotes.Click += new System.EventHandler(this.lblLotes_Click);
			// 
			// txtLotes
			// 
			this.txtLotes.Location = new System.Drawing.Point(112, 33);
			this.txtLotes.Name = "txtLotes";
			this.txtLotes.Size = new System.Drawing.Size(100, 20);
			this.txtLotes.TabIndex = 1;
			this.txtLotes.TextChanged += new System.EventHandler(this.txtLotes_TextChanged);
			this.txtLotes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLotes_KeyPress);
			// 
			// btnLotes
			// 
			this.btnLotes.Location = new System.Drawing.Point(287, 30);
			this.btnLotes.Name = "btnLotes";
			this.btnLotes.Size = new System.Drawing.Size(75, 23);
			this.btnLotes.TabIndex = 2;
			this.btnLotes.Text = "Vender lotes";
			this.btnLotes.UseVisualStyleBackColor = true;
			this.btnLotes.Click += new System.EventHandler(this.btnLotes_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(72, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Opciones:";
			// 
			// FrmMetodos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.gbVentas);
			this.Controls.Add(this.gbCompras);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.rtbProductos);
			this.Name = "FrmMetodos";
			this.Text = "FrmMetodos";
			this.Load += new System.EventHandler(this.FrmMetodos_Load);
			this.gbCompras.ResumeLayout(false);
			this.gbCompras.PerformLayout();
			this.gbVentas.ResumeLayout(false);
			this.gbVentas.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbProductos;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox gbCompras;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.DateTimePicker dtpFechaCompra;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbVentas;
		private System.Windows.Forms.TextBox txtLotes;
		private System.Windows.Forms.Label lblLotes;
		private System.Windows.Forms.Button btnLotes;
		private System.Windows.Forms.Label label4;
	}
}