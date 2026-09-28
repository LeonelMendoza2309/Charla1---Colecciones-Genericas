namespace Charla
{
<<<<<<< HEAD
=======
    // Formulario principal de la aplicación que actúa como contenedor MDI (Multiple Document Interface).
    /// Gestiona la apertura y el ciclo de vida de los formularios hijos.
>>>>>>> update
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void tsb_1_Click(object sender, EventArgs e)
        {
            frm_op1 ventanaTexto = Application.OpenForms.OfType<frm_op1>().FirstOrDefault();
            if (ventanaTexto == null)
            {
=======
        /// Maneja el evento de clic del botón de barra de herramientas 'tsb_1'.
        private void tsb_1_Click(object sender, EventArgs e)
        {
            // Busca si ya existe una instancia abierta del formulario 'frm_op1'
            frm_op1 ventanaTexto = Application.OpenForms.OfType<frm_op1>().FirstOrDefault();
            if (ventanaTexto == null)
            {
                // Si no existe, se crea una nueva instancia, se define su padre MDI y se muestra
>>>>>>> update
                ventanaTexto = new frm_op1();
                ventanaTexto.MdiParent = this;
                ventanaTexto.Show();
            }
            else
            {
<<<<<<< HEAD
=======
                // Si ya está abierto, se trae al frente y se le otorga el foco
>>>>>>> update
                ventanaTexto.BringToFront();
                ventanaTexto.Focus();
            }
        }
<<<<<<< HEAD

        private void tsb_2_Click(object sender, EventArgs e)
        {
            frm_op2 ventanaTexto = Application.OpenForms.OfType<frm_op2>().FirstOrDefault();
            if (ventanaTexto == null)
            {
=======
        /// Maneja el evento de clic del botón de barra de herramientas 'tsb_2'.
        private void tsb_2_Click(object sender, EventArgs e)
        {
            // Busca si ya existe una instancia abierta del formulario 'frm_op2'
            frm_op2 ventanaTexto = Application.OpenForms.OfType<frm_op2>().FirstOrDefault();
            if (ventanaTexto == null)
            {
                // Si no existe, se crea una nueva instancia, se define su padre MDI y se muestra
>>>>>>> update
                ventanaTexto = new frm_op2();
                ventanaTexto.MdiParent = this;
                ventanaTexto.Show();
            }
            else
            {
<<<<<<< HEAD
                ventanaTexto.BringToFront();
                ventanaTexto.Focus();
            }
        }

        private void tsb_3_Click(object sender, EventArgs e)
        {
            frm_op3 ventanaTexto = Application.OpenForms.OfType<frm_op3>().FirstOrDefault();
            if (ventanaTexto == null)
            {
                ventanaTexto = new frm_op3();
                ventanaTexto.MdiParent = this;
                ventanaTexto.Show();
            }
            else
            {
=======
                // Si ya está abierto, se trae al frente y se le otorga el foco
>>>>>>> update
                ventanaTexto.BringToFront();
                ventanaTexto.Focus();
            }
        }
    }
}
