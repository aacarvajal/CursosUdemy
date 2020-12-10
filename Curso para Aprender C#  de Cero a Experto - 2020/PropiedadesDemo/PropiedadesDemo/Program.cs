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

            Triangulo t1 = new Triangulo("rojo")
            {
            
                Lado1 = 20

            };

            Triangulo t2 = new Triangulo("rojo")
            {

                Lado2 = 20

            };

            Triangulo t3 = new Triangulo("rojo")//inicializador de objetos
            {

                Lado1 = 20,
                Lado2 = 20,
                Lado3 = 20

            };

            Triangulo t4 = new Triangulo("rojo")
            {

                Lado1 = 1,
                Lado3 = 2

            }

            //Printer p = new Printer(10, 15);

            //p.Z = 10;

            //p.Print();

            //p.X = 20;
            //p.Y = 15;

            //int x = p.X;
            //int y = p.Y;

            //p.X += 10;

            //p.Print();

            //temp = p.Prueba = 3;

            //p.Print();

            //int x = p.ObtenerX();
            //p.AsignarX(x + 10);

            //p.Print();

            Console.ReadLine();

        }
    }
}
