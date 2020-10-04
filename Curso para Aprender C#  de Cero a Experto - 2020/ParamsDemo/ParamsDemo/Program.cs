using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arrayNum = new int[5];

            int suma = Sumar(1, 2, 3, 4, 5, 6, "110");

            Console.WriteLine(suma);
            Console.ReadLine();

        }

        static int Sumar(int n1, int n2)
        {

            return n1 + n2;

        }

        //no se puede usar params con arrays multidimensionales
        //no se puede sobrecargar un metodo basado en params (aunque tenga la palabra params,
        //no quiere decir que sea un metodo distinto, ya que no lo reconoce como tal, si se creara
        //uno sin params pero con un solo entero, seria una replica, aunque no tuviera params)
        //params debe esta definido al final de la parametrizacion del metodo
        //se da prioridad a los metodos que no tengan "params" en sus parentesis
        /*static int Sumar(params int[] num)
        {

            if (num.Length < 2 || num == null)
            {

                throw new ArgumentException("Incluye dos parametros como minimo");

            }
            else
            {

                int suma = 0;
                foreach (var numero in num)
                {
                    suma += numero;
                }

                return suma;

            }

        }*/

        static int Sumar(params object[] num)
        {

            int suma = 0;

            foreach (var numero in num)
            {

                if(numero is int)
                {

                    suma += (int) numero;

                }else if(numero is string)
                {

                    bool convertir = int.TryParse((string)numero, out int temporal);

                    if (convertir)
                    {

                        suma += temporal;

                    }
                    else
                    {

                        throw new Exception("Valor no numerico");

                    }

                }
                else
                {

                    throw new Exception("Valor no numerico");

                }

            }

            return suma;

        }

    }
}
