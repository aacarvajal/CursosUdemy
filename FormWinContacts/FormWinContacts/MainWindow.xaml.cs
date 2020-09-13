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

        public MainWindow()
        {

            InitializeComponent();

            string conn = ConfigurationManager.ConnectionStrings["FormWinContacts.Properties.Settings.WinFormsContactConnectionString"].ConnectionString;

            sqlcon = new SqlConnection(conn);

            MuestraContactos();

            cdn = new CapaDeNegocio();

        }

        private void Añadir_Click(object sender, RoutedEventArgs e)
        {

            AbrirDetalleContactos();

        }

        private void AbrirDetalleContactos()
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

        private void contactos()
        {

            List<Contactos> contactos = cdn.GetContactos();

            contactosListView.DataContext = contactos;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //FormWinContacts.WinFormsContactDataSet winFormsContactDataSet = ((FormWinContacts.WinFormsContactDataSet)(this.FindResource("winFormsContactDataSet")));
            // Cargar datos en la tabla Contactos. Puede modificar este código según sea necesario.
            /*FormWinContacts.WinFormsContactDataSetTableAdapters.ContactosTableAdapter winFormsContactDataSetContactosTableAdapter = new FormWinContacts.WinFormsContactDataSetTableAdapters.ContactosTableAdapter();
            winFormsContactDataSetContactosTableAdapter.Fill(winFormsContactDataSet.Contactos);
            System.Windows.Data.CollectionViewSource contactosViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contactosViewSource")));
            contactosViewSource.View.MoveCurrentToFirst();*/

            //MuestraContactos();

        }
    }
}
            