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

namespace FormWinContacts
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private string conn = ConfigurationManager.ConnectionStrings["FormWinContacts.Properties.Settings.WinFormsContactConnectionString"].ConnectionString;

        SqlConnection sqlcon;

        public MainWindow()
        {

            InitializeComponent();

            string conn = ConfigurationManager.ConnectionStrings["FormWinContacts.Properties.Settings.WinFormsContactConnectionString"].ConnectionString;

            sqlcon = new SqlConnection(conn);

            MuestraContactos();

        }

        private void Añadir_Click(object sender, RoutedEventArgs e)
        {

            AbrirDetalleContactos();

        }

        private void AbrirDetalleContactos()
        {

            VentanaContactos dc = new VentanaContactos();

            dc.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            dc.ShowDialog();

        }

        private void MuestraContactos()
        {

            try
            {

                string consulta = "select * from Contactos";

                SqlDataAdapter sqlda = new SqlDataAdapter(consulta, sqlcon);

                using (sqlda)
                {

                    DataTable contactoTabla = new DataTable();

                    sqlda.Fill(contactoTabla);//rellena la informacion

                    listaContactos.DisplayMemberPath = "nombre";

                    //listaContactos.DisplayMemberPath = "nombre";
                    //se especifica la columna que quiero que aparezca si es solo una

                    //clave primaria
                    listaContactos.SelectedValuePath = "id";

                    //origen de datos
                    listaContactos.ItemsSource = contactoTabla.DefaultView;

                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());

            }

        }

    }
}
            