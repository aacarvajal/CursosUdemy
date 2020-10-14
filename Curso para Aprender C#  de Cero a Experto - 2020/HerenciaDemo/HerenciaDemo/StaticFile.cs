using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class StaticFile : MultimediaFile
    {

        //public StaticFile(string fechaCreacion, string fechaModificacion,
        //    string nombre, string tipoElemento) 
        //    : base (fechaCreacion,fechaModificacion,nombre,tipoElemento)
        //{



        //}

        /*public virtual void Editar()
        {

            Console.WriteLine("Editando");

        }

        public override void DesplegarInfor()
        {
            //base.DesplegarInfor();//se ejecutaria el metodo de la clase padre

            Console.WriteLine("archivo statico");
        }*/

        public override string ObtenerTipo()
        {
            return "Archivo estatico";
        }

    }
}
