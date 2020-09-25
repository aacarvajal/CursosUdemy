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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using FormsWinContacts;

namespace FormWinContacts
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private string conn = ConfigurationManager.ConnectionStrings["FormWinContacts.Properties.Settings.WinFormsContactConnectionString"].ConnectionString;

        SqlConnection sqlcon;

        CapaDeNegocio cdn;

        VentanaContactos vc;

        public MainWindow()
        {

            InitializeComponent();

            string conn = ConfigurationManager.ConnectionStrings["FormWinContacts.Properties.Settings.WinFormsContactConnectionString"].ConnectionString;

            sqlcon = new SqlConnection(conn);

            MuestraContactos();

            cdn = new CapaDeNegocio();

            vc = new VentanaContactos();

            //contactos();

        }

        private void Añadir_Click(object sender, RoutedEventArgs e)
        {

            VentanaContactos dc = new VentanaContactos();

            dc.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.Close();

            dc.ShowDialog();

        }

        public void MuestraContactos()
        {

            try
            {

                string consulta = "select * from Contactos";

                SqlDataAdapter sqlda = new SqlDataAdapter(consulta, sqlcon);

                using (sqlda)
                {

                    DataTable contactoTabla = new DataTable();

                    sqlda.Fill(contactoTabla);//rellena la informacion

                    //contactosListView.DisplayMemberPath = "nombre";

                    //listaContactos.DisplayMemberPath = "nombre";
                    //se especifica la columna que quiero que aparezca si es solo una

                    //clave primaria
                    //contactosListView.SelectedValuePath = "id";

                    //origen de datos
                    contactosListView.ItemsSource = contactoTabla.DefaultView;

                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());

            }

        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {

            //obtiene el valor de la columna id
            /*int id = (int) contactosListView.SelectedValue;

            vc.CargarContactos(new Contactos
            {

                id = contactosListView.SelectedValuePath[1],
                nombre = contactosListView.SelectedValuePath[2].ToString(),
                apellidos = contactosListView.SelectedValuePath[3].ToString(),
                direccion = contactosListView.SelectedValuePath[4].ToString(),
                telefono = contactosListView.SelectedValuePath[5].ToString()

            }); ;

            vc.ShowDialog();*/

            if (contactosListView.SelectedIndex == -1)
            {

                MessageBox.Show("No has seleccionado nada");

            }
            else
            {

                ActualizaContacto actContact = new ActualizaContacto();//(int)contactosListView.SelectedValue

                actContact.Show();

                try
                {

                    string consulta = "select * from contactos where id = @ClId";

                    SqlCommand sqlcom = new SqlCommand(consulta, sqlcon);

                    SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);

                    using (sqlda)
                    {

                        sqlcom.Parameters.AddWithValue("@ClId", contactosListView.SelectedValue);

                        DataTable clienteTab = new DataTable();

                        sqlda.Fill(clienteTab);

                        //int id = (int) clienteTab.Rows[0]["Id"];
                        actContact.actnombre.Text = clienteTab.Rows[0]["nombre"].ToString();
                        actContact.actapellidos.Text = clienteTab.Rows[0]["apellidos"].ToString();
                        actContact.acttelefono.Text = clienteTab.Rows[0]["telefono"].ToString();
                        actContact.actdireccion.Text = clienteTab.Rows[0]["direccion"].ToString();

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }

            }
        }

        //no sirve
        /*private void contactos()
        {

            List<Contactos> contactos = new List<Contactos>();

            contactos = cdn.GetContactos();

            contactosListView.DataContext = contactos;

        }*/

        /*private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //FormWinContacts.WinFormsContactDataSet winFormsContactDataSet = ((FormWinContacts.WinFormsContactDataSet)(this.FindResource("winFormsContactDataSet")));
            // Cargar datos en la tabla Contactos. Puede modificar este código según sea necesario.
            FormWinContacts.WinFormsContactDataSetTableAdapters.ContactosTableAdapter winFormsContactDataSetContactosTableAdapter = new FormWinContacts.WinFormsContactDataSetTableAdapters.ContactosTableAdapter();
            winFormsContactDataSetContactosTableAdapter.Fill(winFormsContactDataSet.Contactos);
            System.Windows.Data.CollectionViewSource contactosViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contactosViewSource")));
            contactosViewSource.View.MoveCurrentToFirst();

            //MuestraContactos();

            contactos();

        }*/
    }
}
