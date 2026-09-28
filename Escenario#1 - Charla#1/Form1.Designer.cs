namespace Escenario_1___Charla_1
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblNomEmp = new System.Windows.Forms.Label();
            this.lblCed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtEmpl = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.btnInser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(342, 49);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(285, 200);
            this.dgvDatos.TabIndex = 0;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(468, 33);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(44, 13);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "DATOS";
            // 
            // lblNomEmp
            // 
            this.lblNomEmp.AutoSize = true;
            this.lblNomEmp.Location = new System.Drawing.Point(26, 20);
            this.lblNomEmp.Name = "lblNomEmp";
            this.lblNomEmp.Size = new System.Drawing.Size(113, 13);
            this.lblNomEmp.TabIndex = 2;
            this.lblNomEmp.Text = "Nombre del empleado:";
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.Location = new System.Drawing.Point(29, 116);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(40, 13);
            this.lblCed.TabIndex = 3;
            this.lblCed.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(29, 164);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(79, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area de trabajo";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(29, 213);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(39, 13);
            this.lblSal.TabIndex = 6;
            this.lblSal.Text = "Salario";
            // 
            // txtEmpl
            // 
            this.txtEmpl.Location = new System.Drawing.Point(29, 36);
            this.txtEmpl.Name = "txtEmpl";
            this.txtEmpl.Size = new System.Drawing.Size(280, 20);
            this.txtEmpl.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(29, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(280, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(29, 132);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(280, 20);
            this.txtCed.TabIndex = 9;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(29, 180);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(280, 20);
            this.txtArea.TabIndex = 10;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(29, 229);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(280, 20);
            this.txtSal.TabIndex = 11;
            // 
            // btnInser
            // 
            this.btnInser.Location = new System.Drawing.Point(251, 311);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(153, 35);
            this.btnInser.TabIndex = 12;
            this.btnInser.Text = "Insertar";
            this.btnInser.UseVisualStyleBackColor = true;
            this.btnInser.Click += new System.EventHandler(this.btnInser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 383);
            this.Controls.Add(this.btnInser);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtEmpl);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCed);
            this.Controls.Add(this.lblNomEmp);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.dgvDatos);
            this.Name = "Form1";
            this.Text = "Datos del Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblNomEmp;
        private System.Windows.Forms.Label lblCed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtEmpl;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Button btnInser;
    }
}

