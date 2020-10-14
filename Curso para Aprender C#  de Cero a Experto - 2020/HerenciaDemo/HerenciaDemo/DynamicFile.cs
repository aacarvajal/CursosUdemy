using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class DynamicFile : MultimediaFile
    {

        //string duracion;

        //public DynamicFile(string fechaCreacion, string fechaModificacion,
        //    string nombre, string tipoElemento)
        //    : base(fechaCreacion, fechaModificacion, nombre, tipoElemento)
        //{



        //}

        //public DynamicFile()
        //{



        //}

        //añadiendo la palabra "virtual" hara sobreescribible el metodo que lo lleve

        /*public virtual void Reproduciendo()
        {

            Console.WriteLine("Reproduciendo");

        }

        public virtual void Pausar()
        {

            Console.WriteLine("Pausar");

        }

        public virtual void Detener()
        {

            Console.WriteLine("Detener");

        }

        public override void DesplegarInfor()
        {
            //base.DesplegarInfor();//se ejecutaria el metodo de la clase padre

            Console.WriteLine("archivo dinamico");
        }*/

        public override string ObtenerTipo()
        {

            calcularTamano();

            string tArch = tipoArchivo;

            //string.ContarPalabras();

            return "Archivo dinamico";
        }

    }
}
