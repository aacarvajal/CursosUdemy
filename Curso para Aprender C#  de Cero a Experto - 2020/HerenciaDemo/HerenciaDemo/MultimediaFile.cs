using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class MultimediaFile
    {

        /*string fechaCreacion;
        string fechaModificacion;
        string nombre;
        string tipoElemento;

        public MultimediaFile(string fechaCreacion, string fechaModificacion, 
            string nombre, string tipoElemento)
        {

            this.fechaCreacion = fechaCreacion;
            this.fechaModificacion = fechaModificacion;
            this.nombre = nombre;
            this.tipoElemento = tipoElemento;

        }

        public MultimediaFile() { }

        public virtual void DesplegarInfor()
        {

            string info = fechaCreacion + " " + fechaCreacion + " " + nombre + " " + tipoElemento;

            Console.WriteLine(info);

        }

        public override string ToString()
        {

            return "asd";

        }*/

        protected string tipoArchivo;

        public virtual string ObtenerTipo()
        {
            return "archivo multimedia";
        }

        protected void calcularTamano()
        {

        }

    }
}
