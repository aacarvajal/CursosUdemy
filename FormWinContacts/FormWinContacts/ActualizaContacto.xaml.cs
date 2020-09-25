using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
    /// Lógica de interacción para ActualizaContacto.xaml
    /// </summary>
    public partial class ActualizaContacto : Window
    {

        private int idCont;

        SqlConnection conexSql;

        public ActualizaContacto(int id)
        {
            InitializeComponent();

            idCont = id;

            string conexionDB = ConfigurationManager.ConnectionStrings["FormWinContacts.Properties.Settings.WinFormsContactConnectionString"].ConnectionString;

            conexSql = new SqlConnection(conexionDB);

        }

        private void btnCancelarAct_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                string consulta = "update contactos set nombre = @nombre, apellidos = @apellidos, " +
                    "telefono = @telefono, direccion = @direccion where id = " + idCont;

                SqlCommand sqlcom = new SqlCommand(consulta, conexSql);

                //SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);

                conexSql.Open();

                sqlcom.Parameters.AddWithValue("@nombre", actnombre.Text);
                sqlcom.Parameters.AddWithValue("@apellidos", actapellidos.Text);
                sqlcom.Parameters.AddWithValue("@telefono", acttelefono.Text);
                sqlcom.Parameters.AddWithValue("@direccion", actdireccion.Text);

                sqlcom.ExecuteNonQuery();//ejecuta la sentencia

                conexSql.Close();

                MessageBox.Show("Cliente actualizado");

                MainWindow main = new MainWindow();

                main.Show();

                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

        }
    }
}
