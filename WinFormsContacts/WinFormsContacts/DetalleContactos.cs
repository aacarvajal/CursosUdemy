using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsContacts
{
    public partial class DetalleContactos : Form
    {

        CapaDeNegocio cdn;

        public DetalleContactos()
        {
            InitializeComponent();

            cdn = new CapaDeNegocio();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            Contactos c = new Contactos();

            c.nombre = textBoxNombre.Text;
            c.apellidos = textBoxApellido.Text;
            c.telefono = textBoxTlfn.Text;
            c.direccion = textBoxDireccion.Text;

            

        }
    }
}
