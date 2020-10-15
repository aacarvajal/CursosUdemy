using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Linea l = new Linea();
            //Circulo c = new Circulo();

            //IFigura f = c;

            //f = l;

            //f.Dibujar();

            //l.Dibujar();

            //IFigura f1 = c;

            //f1.Dibujar();

            //IRenderizador ir = c;

            //ir.Dibujar();

            

        }

        static void CalcularArea(IFigura f)
        {

            if(f is Circulo)
            {
                f.Dibujar();
            }
            else if (f is Linea)
            {
                f.Dibujar();
            }

        }

    }
}
