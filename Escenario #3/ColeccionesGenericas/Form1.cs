using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace ColeccionesGenericas
{
    public partial class Form1 : Form
    {
        List<Libro> libros = new List<Libro>();

        Dictionary<int, Libro> librosPorId = new Dictionary<int, Libro>();

        Queue<Libro> colaPrestamos = new Queue<Libro>();

        Stack<Libro> historialLibros = new Stack<Libro>();

        int cantidadMaxima = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument documento = new XmlDocument();

            documento.Load("config.xml");

            XmlNode nodo = documento.SelectSingleNode("/configuracion/cantidadMaxima");

            cantidadMaxima = int.Parse(nodo.InnerText);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar que los cuatro campos estén llenos
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtTítulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Verificar que el ID sea numérico
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("El ID debe contener solamente números.");
                return;
            }

            // Verificar que no exista otro libro con el mismo ID
            if (librosPorId.ContainsKey(id))
            {
                MessageBox.Show("Ya existe un libro con ese ID.");
                return;
            }

            // Verificar que el precio sea numérico
            double precio;

            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe contener solamente números.");
                return;
            }

            // Verificar que el autor solamente tenga letras y espacios
            foreach (char caracter in txtAutor.Text)
            {
                if (!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter))
                {
                    MessageBox.Show("El autor debe contener solamente letras.");
                    return;
                }
            }

            // Verificar la cantidad máxima de libros
            if (libros.Count >= cantidadMaxima)
            {
                MessageBox.Show("Se alcanzó la cantidad máxima de libros permitida.");
                return;
            }

            // Obtener los datos
            string titulo = txtTítulo.Text;
            string autor = txtAutor.Text;

            // Crear el libro
            Libro libro = new Libro(id, titulo, autor, precio);

            // Agregar el libro a la List
            libros.Add(libro);

            // Agregar el libro al Dictionary
            librosPorId.Add(libro.Id, libro);

            // Agregar el libro al Stack
            historialLibros.Push(libro);

            // Agregar el libro a la Queue
            colaPrestamos.Enqueue(libro);

            // Agregar el libro al DataGridView
            dgvLibros.Rows.Add(
                libro.Id,
                libro.Titulo,
                libro.Autor,
                libro.Precio
            );

            // Limpiar los campos
            txtId.Clear();
            txtTítulo.Clear();
            txtAutor.Clear();
            txtPrecio.Clear();

            MessageBox.Show("Libro agregado correctamente.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtTítulo.Clear();
            txtAutor.Clear();
            txtPrecio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verificar que se haya escrito un ID
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                MessageBox.Show("Ingrese un ID para buscar.");
                return;
            }

            // Verificar que el ID sea numérico
            int id;

            if (!int.TryParse(txtBuscarId.Text, out id))
            {
                MessageBox.Show("El ID debe contener solamente números.");
                return;
            }

            // Buscar el libro en el Dictionary
            if (librosPorId.ContainsKey(id))
            {
                Libro libro = librosPorId[id];

                MessageBox.Show(
                    "Libro encontrado\n\n" +
                    "ID: " + libro.Id + "\n" +
                    "Título: " + libro.Titulo + "\n" +
                    "Autor: " + libro.Autor + "\n" +
                    "Precio: B/." + libro.Precio.ToString("0.00")
                );
            }
            else
            {
                MessageBox.Show("No se encontró ningún libro con ese ID.");
            }

            // Limpiar el campo de búsqueda
            txtBuscarId.Clear();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            if (colaPrestamos.Count == 0)
            {
                MessageBox.Show("No hay libros en la cola de préstamos.");
                return;
            }

            string mensaje = "Registro de préstamos:\n\n";

            int numero = 1;

            foreach (Libro libro in colaPrestamos)
            {
                mensaje += numero + ". " +
                           libro.Titulo +
                           " - ID: " + libro.Id +
                           "\n";

                numero++;
            }

            MessageBox.Show(mensaje);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (historialLibros.Count == 0)
            {
                MessageBox.Show("No hay libros en el historial.");
                return;
            }

            string mensaje = "Historial de libros:\n\n";

            int numero = 1;

            foreach (Libro libro in historialLibros)
            {
                mensaje += numero + ". " +
                           libro.Titulo +
                           " - ID: " + libro.Id +
                           "\n";

                numero++;
            }

            MessageBox.Show(mensaje);
        }
    }
}