using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{

    class FiguraDeribada : FiguraBase
    {
        //se sellan los metodos para que no pueda ser reimplementado
        public sealed override void ObtenerTop()
        {
            throw new NotImplementedException();
        }

        public sealed override void ObtenerUbicacion()
        {
            base.ObtenerUbicacion();
        }

    }

    abstract class FiguraBase
    {

        //una clase abstracta no puede ser privado
        //un metodo abstracto no tendra logica de implementacion
        protected string colorFigura;

        public virtual void ObtenerUbicacion()
        {
            Console.WriteLine("X Y");
        }

        public abstract void ObtenerTop();

    }
}
