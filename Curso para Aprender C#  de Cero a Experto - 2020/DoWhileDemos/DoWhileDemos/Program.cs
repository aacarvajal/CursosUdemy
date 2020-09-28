using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDemos
{
    class Program
    {
        static void Main(string[] args)
        {

            //do
            //enunciado
            //while (expresion booleana);

            do
            {

                Console.WriteLine("Hello");

            } while (8 > 10);

            /*while (8 > 10)
             {
                 //nunca se ejecutara
             }*/

            int i = 1;
            int suma = 0;

            /*do
            {

                Console.WriteLine(i);
                i++;

            } while (i <= 10);*/

            do
            {

                suma += i;
                i++;

            } while (i <= 10);

            Console.WriteLine(suma);

            Console.ReadLine();

        }
    }
}
