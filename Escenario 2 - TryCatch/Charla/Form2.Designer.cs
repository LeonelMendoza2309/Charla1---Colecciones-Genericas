namespace Charla
{
    partial class frm_op1
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
            components = new System.ComponentModel.Container();
            lblPeso = new Label();
            lblAltura = new Label();
<<<<<<< HEAD
            lblImc = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            txtImc = new TextBox();
=======
            txtPeso = new TextBox();
            txtAltura = new TextBox();
>>>>>>> update
            imageList1 = new ImageList(components);
            btnCalcular = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
<<<<<<< HEAD
            lblPeso.Location = new Point(31, 31);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(63, 32);
=======
            lblPeso.Location = new Point(17, 15);
            lblPeso.Margin = new Padding(2, 0, 2, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
>>>>>>> update
            lblPeso.TabIndex = 0;
            lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
<<<<<<< HEAD
            lblAltura.Location = new Point(31, 86);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(77, 32);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura";
            // 
            // lblImc
            // 
            lblImc.AutoSize = true;
            lblImc.Location = new Point(31, 139);
            lblImc.Name = "lblImc";
            lblImc.Size = new Size(57, 32);
            lblImc.TabIndex = 2;
            lblImc.Text = "IMC";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(125, 28);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(200, 39);
=======
            lblAltura.Location = new Point(17, 57);
            lblAltura.Margin = new Padding(2, 0, 2, 0);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(39, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(67, 13);
            txtPeso.Margin = new Padding(2, 1, 2, 1);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(110, 23);
>>>>>>> update
            txtPeso.TabIndex = 3;
            // 
            // txtAltura
            // 
<<<<<<< HEAD
            txtAltura.Location = new Point(125, 83);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(200, 39);
            txtAltura.TabIndex = 4;
            // 
            // txtImc
            // 
            txtImc.Location = new Point(125, 136);
            txtImc.Name = "txtImc";
            txtImc.Size = new Size(200, 39);
            txtImc.TabIndex = 5;
            // 
=======
            txtAltura.Location = new Point(67, 56);
            txtAltura.Margin = new Padding(2, 1, 2, 1);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(110, 23);
            txtAltura.TabIndex = 4;
            // 
>>>>>>> update
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnCalcular
            // 
<<<<<<< HEAD
            btnCalcular.Location = new Point(454, 43);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
=======
            btnCalcular.Location = new Point(244, 20);
            btnCalcular.Margin = new Padding(2, 1, 2, 1);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(81, 22);
>>>>>>> update
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
<<<<<<< HEAD
            btnLimpiar.Location = new Point(454, 112);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 46);
=======
            btnLimpiar.Location = new Point(244, 52);
            btnLimpiar.Margin = new Padding(2, 1, 2, 1);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 22);
>>>>>>> update
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frm_op1
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 207);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtImc);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(lblImc);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
=======
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 97);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Margin = new Padding(2, 1, 2, 1);
>>>>>>> update
            Name = "frm_op1";
            Text = "Calculador de IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPeso;
        private Label lblAltura;
<<<<<<< HEAD
        private Label lblImc;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private TextBox txtImc;
=======
        private TextBox txtPeso;
        private TextBox txtAltura;
>>>>>>> update
        private ImageList imageList1;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}