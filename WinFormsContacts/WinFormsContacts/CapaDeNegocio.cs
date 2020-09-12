using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WinFormsContacts;

namespace FormsWinContacts
{
    public class CapaDeNegocio
    {

        private CapaAccesoDatos cad;

        public CapaDeNegocio()
        {

            cad = new CapaAccesoDatos();

        }

        public Contactos GuardarContacto(Contactos c)
        {

            if(c.id == 0)
            {

                cad.InsertarContactos(c);
                MessageBox.Show("Contacto añadido");

            }
            else
            {

                //cad.ActualizarContactos();

            }

            return c;

        }

    }
}
