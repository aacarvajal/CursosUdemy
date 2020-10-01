using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static ClasesDemo1.Circulo;

namespace ClasesDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Rectangulo r1 = new Rectangulo(23,50);
            Rectangulo r2 = new Rectangulo();

            double resArea = r1.CalcularArea();
            double restPer = r1.CalculaPerimetro();
            double resPer2 = Rectangulo.CalcPerRect(1111,123); ;

            //Console.WriteLine(r1.CalcularArea());
            //Console.WriteLine(r1.CalculaPerimetro());

            (var baseRect, var alturaRect) = r1;

            Console.WriteLine(baseRect);
            Console.WriteLine(alturaRect);
            
            Console.WriteLine(Math.Pow(2,2));

            Console.WriteLine(resArea);
            Console.WriteLine(restPer);
            Console.WriteLine(resPer2);*/

            Circulo c1 = new Circulo(3);
            Circulo c2 = new Circulo(4);
            Circulo c3 = new Circulo(5);

            //Circulo.PI = 5;

            Console.WriteLine(Circulo.numCirc);

            //clases anonimas
            var objAnon = new { area = 3 };

            Console.ReadLine();

        }
    }
}
