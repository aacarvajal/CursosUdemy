using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionRecursosDemo
{
    class FileManager : IDisposable
    {

        FileStream reader = null;

        public FileManager(string filePath)
        {
            //using (FileStream reader = File.Open(filePath, FileMode.Open))
            //{

            //    byte[] b = new byte[1024];

            //    UTF8Encoding temp = new UTF8Encoding();

            //    while (reader.Read(b, 0, b.Length) > 0)
            //    {

            //        Console.WriteLine(temp.GetString(b));

            //    }

            //}             

            //try
            //{

                reader = File.Open(filePath, FileMode.Open);

                byte[] b = new byte[1024];

                UTF8Encoding temp = new UTF8Encoding();

                while (reader.Read(b, 0, b.Length) > 0)
                {

                    Console.WriteLine(temp.GetString(b));

                }

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{

            //    reader.Close();

            //}

        }

        ~FileManager()
        {

            System.Diagnostics.Trace.WriteLine("Archivo cerrado");

        }

        void IDisposable.Dispose()
        {
            reader?.Dispose();//? pregunta si es nula o no, si no lo es, se ejecuta el dispose()
        }

        //void IDisposable.Dispose()
        //{
        //    ((IDisposable)reader).Dispose();
        //}
    }
}
