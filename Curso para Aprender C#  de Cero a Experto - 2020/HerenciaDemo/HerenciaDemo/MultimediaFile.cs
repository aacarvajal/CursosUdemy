using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class MultimediaFile
    {

        string fechaCreacion;
        string fechaModificacion;
        string nombre;
        string tipoElemento;

        public void DesplegarInfor()
        {

            string info = fechaCreacion + " " + fechaCreacion + " " + nombre + " " + tipoElemento;

            Console.WriteLine(info);

        }

    }
}
