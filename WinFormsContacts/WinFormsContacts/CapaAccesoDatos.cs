using FormsWinContacts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace FormsWinContacts
{
    public class CapaAccesoDatos
    {

        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContact;Data Source=DESKTOP-IP0D3I2");
        //private SqlConnection conn = new SqlConnection("FormWinContacts.Properties.Settings.WinFormsContactConnectionString");

        public void InsertarContactos(Contactos c)
        {

            try
            {

                conn.Open();

                string query = @"insert into Contactos(nombre, apellidos, telefono, direccion) values (@Nombre, @Apeliidos, @Telefono, @Direccion)";

                SqlParameter nombre = new SqlParameter();

                nombre.ParameterName = "@Nombre";

                nombre.Value = c.nombre;

                nombre.DbType = System.Data.DbType.String;

                SqlParameter apellidos = new SqlParameter("@Apeliidos", c.apellidos);
                SqlParameter telefono = new SqlParameter("@Telefono", c.telefono);
                SqlParameter direccion = new SqlParameter("@Direccion", c.direccion);

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(nombre);
                command.Parameters.Add(apellidos);
                command.Parameters.Add(telefono);
                command.Parameters.Add(direccion);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                conn.Close();

            }

        }

        public List<Contactos> GetContactos()
        {

            List<Contactos> contacto = new List<Contactos>();

            try
            {

                conn.Open();

                string query = @" select nombre, apellidos, telefono, direccion from Contactos";

                SqlCommand comm = new SqlCommand(query);

                SqlDataReader read = comm.ExecuteReader();

                while (read.Read())
                {

                    contacto.Add(new Contactos
                    {

                        id = int.Parse(read["id"].ToString()),
                        nombre = read["nombre"].ToString(),
                        apellidos = read["apellidos"].ToString(),
                        telefono = read["telefono"].ToString(),
                        direccion = read["direccion "].ToString()
                    });

                }

            }
            catch (Exception e)
            {

                //throw;

                MessageBox.Show(e.ToString());

            }
            finally
            {
                conn.Close();
            }

            return contacto;

        }

    }
}
