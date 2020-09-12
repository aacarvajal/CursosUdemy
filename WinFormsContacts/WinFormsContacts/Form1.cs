using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsContacts
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            AbrirDetalleContactos();

        }
        private void AbrirDetalleContactos()
        {

            DetalleContactos dc = new DetalleContactos();

            dc.StartPosition = FormStartPosition.CenterParent;

            dc.ShowDialog();

        }

    }
}
