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
    /// Lógica de interacción para ActualizaContacto.xaml
    /// </summary>
    public partial class ActualizaContacto : Window
    {
        public ActualizaContacto()
        {
            InitializeComponent();
        }

        private void btnCancelarAct_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
