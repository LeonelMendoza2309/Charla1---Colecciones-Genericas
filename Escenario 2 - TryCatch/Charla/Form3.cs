using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

<<<<<<< HEAD
=======
using System;
using System.Windows.Forms;

>>>>>>> update
namespace Charla
{
    public partial class frm_op2 : Form
    {

        private readonly Random rnd = new Random();


        public frm_op2()
        {
            InitializeComponent();
        }

    }
}


        private void btnComprobar_Click(object sender, EventArgs e)
        {
            try
            {
                // FormatException si el texto no es un entero válido
                int numUser = int.Parse(txtNumero.Text);

                // Validar el rango mediante una excepción manual ArgumentOutOfRangeException
                if (numUser < 1 || numUser > 9)
                {
                    throw new ArgumentOutOfRangeException("El número ingresado no está en el rango de 1 a 9.");
                }

                // Genera un número aleatorio entre 1 y 9 
                int numSecreto = rnd.Next(1, 10);

                // Compara el número ingresado con el generado
                if (numUser == numSecreto)
                {
                    MessageBox.Show("¡Felicidades! Has adivinado el número.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No has acertado. ¡Inténtalo de nuevo!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Muestra el número generado en la etiqueta
                lblRespuesta.Text = numSecreto.ToString();
            }
            catch (FormatException)
            {
                // Captura errores cuando el usuario escribe letras, símbolos o deja la casilla vacía
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentOutOfRangeException)
            {
                // Captura la excepción lanzada cuando el número no está entre 1 y 9
                MessageBox.Show("El número debe estar entre 1 y 9.", "Número fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Captura cualquier otro error imprevisto
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

