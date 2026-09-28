namespace ColeccionesGenericas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTítulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTítulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID: ";
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Location = new System.Drawing.Point(25, 99);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(46, 16);
            this.lblTítulo.TabIndex = 1;
            this.lblTítulo.Text = "Título: ";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(25, 151);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(41, 16);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(25, 211);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(234, 22);
            this.txtId.TabIndex = 4;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTítulo
            // 
            this.txtTítulo.Location = new System.Drawing.Point(115, 93);
            this.txtTítulo.Name = "txtTítulo";
            this.txtTítulo.Size = new System.Drawing.Size(234, 22);
            this.txtTítulo.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(115, 205);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(234, 22);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(115, 151);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(234, 22);
            this.txtAutor.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(50, 260);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 34);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(175, 260);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 34);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(309, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 34);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTítulo,
            this.colAutor,
            this.colPrecio});
            this.dgvLibros.Location = new System.Drawing.Point(28, 320);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(1086, 284);
            this.dgvLibros.TabIndex = 11;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Width = 125;
            // 
            // colTítulo
            // 
            this.colTítulo.HeaderText = "Título";
            this.colTítulo.MinimumWidth = 6;
            this.colTítulo.Name = "colTítulo";
            this.colTítulo.Width = 125;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 6;
            this.colAutor.Name = "colAutor";
            this.colAutor.Width = 125;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 125;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1010, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(710, 28);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(91, 16);
            this.lblBuscarId.TabIndex = 13;
            this.lblBuscarId.Text = "Buscar por ID:";
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(804, 22);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(176, 22);
            this.txtBuscarId.TabIndex = 14;
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Location = new System.Drawing.Point(879, 259);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(111, 35);
            this.btnPrestamos.TabIndex = 15;
            this.btnPrestamos.Text = "Ver Préstamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(1015, 260);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(99, 34);
            this.btnHistorial.TabIndex = 16;
            this.btnHistorial.Text = "Ver Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 616);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.lblBuscarId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTítulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Registro de Libros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTítulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTítulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnHistorial;
    }
}

