using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer p = new Printer(10, 15);

            p.Print();

            p.X = 20;
            p.Y = 15;

            int x = p.X;
            int y = p.Y;

            p.X += 10;

            p.Print();

            //temp = p.Prueba = 3;

            //p.Print();

            //int x = p.ObtenerX();
            //p.AsignarX(x + 10);

            //p.Print();

            Console.ReadLine();

        }
    }
}
