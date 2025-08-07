using System;
using System.Windows.Forms;

namespace AgendaContactosWinForms
{
    public partial class Form1 : Form
    {
        private ListaEnlazadaAgenda agenda = new ListaEnlazadaAgenda();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var contacto = new Contact(txtNombre.Text, txtTelefono.Text, txtCorreo.Text);
            agenda.Add(contacto);
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool eliminado = agenda.Delete(txtNombre.Text);
            MessageBox.Show(eliminado ? "Contacto eliminado." : "Contacto no encontrado.");
            LimpiarCampos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstContactos.Items.Clear();
            var contactos = agenda.GetAll();
            foreach (var c in contactos)
            {
                lstContactos.Items.Add(c.ToString());
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
