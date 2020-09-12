using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsContacts
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

                //cad.InsertarContactos();

            }
            else
            {

                //cad.ActualizarContactos();

            }

        }

    }
}
