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
    /// 
    public partial class VentanaContactos : Window
    {

        CapaDeNegocio cdn;
        MainWindow mw;

        //Contactos cont;

        //public VentanaContactos(int id){}

        public VentanaContactos()
        {
            InitializeComponent();

            cdn = new CapaDeNegocio();
            //mw = new MainWindow();

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
            mw.MuestraContactos();
            mw.Show();

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

            mw.MuestraContactos();

            mw.Show();

        }

        public void CargarContactos(Contactos c)
        {

            //int idContacto = id;

            //cont = c;

            if(c != null)
            {

                ClearForm();

                nombre.Text = c.nombre;

                apellidos.Text = c.apellidos;

                direccion.Text = c.direccion;

                telefono.Text = c.telefono;

            }

        }

        private void ClearForm()
        {

            nombre.Text = string.Empty;

            apellidos.Text = string.Empty;

            direccion.Text = string.Empty;

            telefono.Text = string.Empty;

        }

    }
}
