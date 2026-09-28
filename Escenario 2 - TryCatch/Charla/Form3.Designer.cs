namespace Charla
{
    partial class frm_op2
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
<<<<<<< HEAD
            SuspendLayout();
            // 
            // frm_op2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "frm_op2";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion
=======
            lblNumero = new Label();
            txtNumero = new TextBox();
            btnComprobar = new Button();
            lblRespuesta = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(34, 11);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(157, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingrese un numero entre 0-9";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(38, 49);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnComprobar
            // 
            btnComprobar.Location = new Point(167, 49);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(87, 23);
            btnComprobar.TabIndex = 2;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = true;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(38, 87);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(0, 15);
            lblRespuesta.TabIndex = 3;
            // 
            // frm_op2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 124);
            Controls.Add(lblRespuesta);
            Controls.Add(btnComprobar);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frm_op2";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Button btnComprobar;
        private Label lblRespuesta;
>>>>>>> update
    }
}