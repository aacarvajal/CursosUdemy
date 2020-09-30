using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangulo r1 = new Rectangulo(23,50);
            Rectangulo r2 = new Rectangulo();

            double resArea = r1.CalcularArea();
            double restPer = r1.CalculaPerimetro();
            double resPer2 = Rectangulo.CalcPerRect(1111,123); ;

            //Console.WriteLine(r1.CalcularArea());
            //Console.WriteLine(r1.CalculaPerimetro());

            (var baseRect, var alturaRect) = r1;

            Console.WriteLine(resArea);
            Console.WriteLine(restPer);
            Console.WriteLine(resPer2);

            Console.ReadLine();

        }
    }
}
