using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsContacts
{
    public class CapaAccesoDatos
    {

        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContact;Data Source=DESKTOP-IP0D3I2");

        public void InsertarContactos(Contactos c)
        {

            try
            {

                conn.Open();

                string query = @"insert into Contactos(nombre, apellidos, telefono, direccion) values (@Nombre, @Apeliidos, @Telefono, @Direccion)";

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
