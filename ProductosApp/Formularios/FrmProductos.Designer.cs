namespace ProductosApp.Formularios
{
    partial class FrmProductos
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.cmbFinderType = new System.Windows.Forms.ComboBox();
			this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
			this.txtFinder = new System.Windows.Forms.TextBox();
			this.rtbProductView = new System.Windows.Forms.RichTextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.llbProductoMetodo = new System.Windows.Forms.Label();
			this.btnComprobar = new System.Windows.Forms.Button();
			this.txtIDProducto = new System.Windows.Forms.TextBox();
			this.cmbMetodos = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnDelete);
			this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
			this.flowLayoutPanel1.Controls.Add(this.btnNew);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 322);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 34);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(505, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 24);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.Text = "Eliminar";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(426, 2);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 24);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Modificar";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(347, 2);
			this.btnNew.Margin = new System.Windows.Forms.Padding(2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 24);
			this.btnNew.TabIndex = 2;
			this.btnNew.Text = "Nuevo";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
			// 
			// cmbFinderType
			// 
			this.cmbFinderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFinderType.FormattingEnabled = true;
			this.cmbFinderType.Items.AddRange(new object[] {
            "Id",
            "Rango Precio",
            "Fecha vencimiento",
            "Unidad Medida"});
			this.cmbFinderType.Location = new System.Drawing.Point(9, 10);
			this.cmbFinderType.Margin = new System.Windows.Forms.Padding(2);
			this.cmbFinderType.Name = "cmbFinderType";
			this.cmbFinderType.Size = new System.Drawing.Size(164, 21);
			this.cmbFinderType.TabIndex = 1;
			this.cmbFinderType.SelectedIndexChanged += new System.EventHandler(this.CmbFinderType_SelectedIndexChanged);
			// 
			// cmbMeasureUnit
			// 
			this.cmbMeasureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMeasureUnit.FormattingEnabled = true;
			this.cmbMeasureUnit.Location = new System.Drawing.Point(176, 10);
			this.cmbMeasureUnit.Margin = new System.Windows.Forms.Padding(2);
			this.cmbMeasureUnit.Name = "cmbMeasureUnit";
			this.cmbMeasureUnit.Size = new System.Drawing.Size(143, 21);
			this.cmbMeasureUnit.TabIndex = 2;
			this.cmbMeasureUnit.Visible = false;
			// 
			// txtFinder
			// 
			this.txtFinder.Location = new System.Drawing.Point(176, 10);
			this.txtFinder.Margin = new System.Windows.Forms.Padding(2);
			this.txtFinder.Name = "txtFinder";
			this.txtFinder.Size = new System.Drawing.Size(318, 20);
			this.txtFinder.TabIndex = 3;
			this.txtFinder.Visible = false;
			// 
			// rtbProductView
			// 
			this.rtbProductView.Location = new System.Drawing.Point(9, 34);
			this.rtbProductView.Margin = new System.Windows.Forms.Padding(2);
			this.rtbProductView.Name = "rtbProductView";
			this.rtbProductView.ReadOnly = true;
			this.rtbProductView.Size = new System.Drawing.Size(583, 284);
			this.rtbProductView.TabIndex = 4;
			this.rtbProductView.Text = "";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(498, 11);
			this.btnFind.Margin = new System.Windows.Forms.Padding(2);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(91, 19);
			this.btnFind.TabIndex = 5;
			this.btnFind.Text = "Buscar";
			this.btnFind.UseVisualStyleBackColor = true;
			// 
			// llbProductoMetodo
			// 
			this.llbProductoMetodo.AutoSize = true;
			this.llbProductoMetodo.Location = new System.Drawing.Point(605, 79);
			this.llbProductoMetodo.Name = "llbProductoMetodo";
			this.llbProductoMetodo.Size = new System.Drawing.Size(231, 13);
			this.llbProductoMetodo.TabIndex = 6;
			this.llbProductoMetodo.Text = "Buscar ID de producto a implementar metodos: ";
			this.llbProductoMetodo.Visible = false;
			// 
			// btnComprobar
			// 
			this.btnComprobar.Location = new System.Drawing.Point(680, 151);
			this.btnComprobar.Name = "btnComprobar";
			this.btnComprobar.Size = new System.Drawing.Size(75, 23);
			this.btnComprobar.TabIndex = 7;
			this.btnComprobar.Text = "Buscarlo";
			this.btnComprobar.UseVisualStyleBackColor = true;
			this.btnComprobar.Visible = false;
			this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
			// 
			// txtIDProducto
			// 
			this.txtIDProducto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIDProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtIDProducto.Location = new System.Drawing.Point(671, 116);
			this.txtIDProducto.Name = "txtIDProducto";
			this.txtIDProducto.Size = new System.Drawing.Size(100, 22);
			this.txtIDProducto.TabIndex = 8;
			this.txtIDProducto.Text = "               ID";
			this.txtIDProducto.Visible = false;
			this.txtIDProducto.WordWrap = false;
			this.txtIDProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtIDProducto_MouseClick);
			this.txtIDProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProducto_KeyPress);
			// 
			// cmbMetodos
			// 
			this.cmbMetodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMetodos.FormattingEnabled = true;
			this.cmbMetodos.Items.AddRange(new object[] {
            "UEPS",
            "PEPS",
            "Método Simple",
            "Promedio Ponderado"});
			this.cmbMetodos.Location = new System.Drawing.Point(650, 180);
			this.cmbMetodos.Name = "cmbMetodos";
			this.cmbMetodos.Size = new System.Drawing.Size(121, 21);
			this.cmbMetodos.TabIndex = 9;
			this.cmbMetodos.Visible = false;
			this.cmbMetodos.SelectedIndexChanged += new System.EventHandler(this.cmbMetodos_SelectedIndexChanged);
			// 
			// FrmProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 391);
			this.Controls.Add(this.cmbMetodos);
			this.Controls.Add(this.txtIDProducto);
			this.Controls.Add(this.btnComprobar);
			this.Controls.Add(this.llbProductoMetodo);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.rtbProductView);
			this.Controls.Add(this.txtFinder);
			this.Controls.Add(this.cmbMeasureUnit);
			this.Controls.Add(this.cmbFinderType);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmProductos";
			this.Text = "Catalogo de productos";
			this.Load += new System.EventHandler(this.FrmProductos_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbFinderType;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.TextBox txtFinder;
        private System.Windows.Forms.RichTextBox rtbProductView;
        private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Label llbProductoMetodo;
		private System.Windows.Forms.Button btnComprobar;
		private System.Windows.Forms.TextBox txtIDProducto;
		private System.Windows.Forms.ComboBox cmbMetodos;
	}
}