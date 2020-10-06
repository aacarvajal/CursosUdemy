using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class DynamicFile : MultimediaFile
    {

        string duracion;

        public void Reproduciendo()
        {

            Console.WriteLine("Reproduciendo");

        }

        public void Pausar()
        {

            Console.WriteLine("Pausar");

        }

        public void Detener()
        {

            Console.WriteLine("Detener");

        }

    }
}
