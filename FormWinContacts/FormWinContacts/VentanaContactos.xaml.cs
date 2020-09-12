using FormsWinContacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FormWinContacts
{
    /// <summary>
    /// Lógica de interacción para VentanaContactos.xaml
    /// </summary>
    public partial class VentanaContactos : Window
    {

        CapaDeNegocio cdn;

        public VentanaContactos()
        {
            InitializeComponent();

            cdn = new CapaDeNegocio();

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

            Contactos c = new Contactos();

            c.nombre = nombre.Text;
            c.apellidos = apellidos.Text;
            c.telefono = telefono.Text;
            c.direccion = direccion.Text;

            cdn.GuardarContacto(c);

            this.Close();

        }
    }
}
