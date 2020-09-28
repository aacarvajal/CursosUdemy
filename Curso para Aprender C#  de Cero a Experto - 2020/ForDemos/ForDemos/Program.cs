using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemos
{
    class Program
    {
        static void Main(string[] args)
        {

            //for(inicializacion; expresion booleana; act var control)
            //{
            // Enunciados
            //}

            Console.WriteLine("Incremento");

            for (int i = 0; i <= 10; i++)
            {

                Console.WriteLine(i);

            }

            Console.WriteLine("\nSuma");

            int suma = 0;

            for (int i = 0; i <= 10; i++)
            {

                Console.WriteLine(suma += i);

            }

            //puede estar vacio el interior del parentesis del for
            //for (; ; )
            //{

            //}

            /*for (int i = 0, j = 10; i < j; i++, j--)
            {

                Console.WriteLine(i);
                Console.WriteLine(j);

            }*/

            Console.ReadLine();

        }
    }
}
