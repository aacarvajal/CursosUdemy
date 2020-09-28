using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDemos
{
    class Program
    {
        static void Main(string[] args)
        {

            //while (expresion booleana)
            //enunciados a ejecutar

            bool vari = true;

            while (vari)
            {

                Console.WriteLine("Bucle while infinito");
                vari = false;

            }

            int i = 1;
            int suma = 0;

            while (i <= 10)
            {

                suma += i;
                i++;
                Console.WriteLine(suma);

            }

            string input = string.Empty;

            while (input != "salir")
            {

                Console.WriteLine("Ejecutando");

                input = Console.ReadLine();

            }

            //Console.WriteLine(suma);

            Console.ReadLine();

        }
    }
}
