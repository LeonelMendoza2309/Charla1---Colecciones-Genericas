using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Charla
{
<<<<<<< HEAD
=======
    // Formulario secundario para el cálculo del Índice de Masa Corporal (IMC).
>>>>>>> update
    public partial class frm_op1 : Form
    {
        public frm_op1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

=======
        // Maneja el evento Clic del botón de cálculo.
        // Valida los datos de entrada, calcula el IMC e informa la categoría correspondiente.
>>>>>>> update
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                decimal peso = decimal.Parse(txtPeso.Text);
                decimal altura = decimal.Parse(txtAltura.Text);
                decimal imc = peso/(altura * altura);
                if (imc < 18.5) {
                    MessageBox.Show("Su IMC está por debajo del rango normal.");
                }
                else if (imc >= 18.5 && imc < 25) {
=======
                // Conversión de texto a valor numérico decimal
                decimal peso = decimal.Parse(txtPeso.Text);
                decimal altura = decimal.Parse(txtAltura.Text);
                // Cálculo del Índice de Masa Corporal: IMC = Peso / (Altura^2)
                decimal imc = peso/(altura * altura);
                // Clasificación según los rangos estándar de IMC
                if (imc < 18.5m) {
                    MessageBox.Show("Su IMC está por debajo del rango normal.");
                }
                else if (imc >= 18.5m && imc < 25) {
>>>>>>> update
                    MessageBox.Show("Su IMC está dentro del rango normal.");
                }
                else {
                    MessageBox.Show("Su IMC está por encima del rango normal.");
                }
            }
<<<<<<< HEAD
            catch
=======
            catch // Captura entradas no numéricas o divisiones por cero (altura = 0)
>>>>>>> update
            {
                MessageBox.Show("Por favor, ingrese valores válidos para peso y altura.");
            }
        }
<<<<<<< HEAD

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtImc.Clear();
=======
        // Maneja el evento Clic del botón de limpieza.
        // Restablece los campos de texto del formulario a su estado inicial
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
>>>>>>> update
            txtPeso.Clear();
        }
    }
}
