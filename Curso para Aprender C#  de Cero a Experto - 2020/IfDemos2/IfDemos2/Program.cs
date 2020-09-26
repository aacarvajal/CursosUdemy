using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemos2
{
    class Program
    {
        static void Main(string[] args)
        {

            //if(expresion booleana)
            //  enunciado -1
            //else
            //  enunciado -2

            /*if(5 == 5)
            {
                Console.WriteLine("Si");
            }
            else
            {
                Console.WriteLine("No");
            }


            bool mayorEdad = true;

            int costeEntrada = 0;

            if (mayorEdad == true)
            {
                Console.WriteLine("mayor de edad");
            }
            else
            {
                Console.WriteLine("menor de edad");
            }*/

            int dia = 3;

            if(dia == 0)
            {
                Console.WriteLine("Lunes");
            }
            else if(dia == 1)
            {
                Console.WriteLine("Martes");
            }
            else if (dia == 2)
            {
                Console.WriteLine("Miercoles");
            }
            else if (dia == 3)
            {
                Console.WriteLine("Jueves");
            }
            else if (dia == 4)
            {
                Console.WriteLine("Viernes");
            }
            else if (dia == 5)
            {
                Console.WriteLine("Sabado");
            }
            else if (dia == 6)
            {
                Console.WriteLine("Domingo");
            }

            Console.ReadLine();

        }
    }
}
