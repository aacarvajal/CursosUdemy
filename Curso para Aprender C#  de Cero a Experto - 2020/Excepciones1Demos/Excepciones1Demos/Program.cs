using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones1Demos
{
    class Program
    {
        static void Main(string[] args)
        {

            //int valor = 10;
            //Console.WriteLine(valor / 0);

            //string num = "a10";
            //int valor = int.Parse(num);

            //string num = "9999999999";
            //int valor = int.Parse(num);

            //Console.WriteLine(valor);

            //try
            //{
            //      operaciones que hay que comprobar
            //}
            //catch (tipo de excepcion ex)
            //{
            //    operacion a ejecutar en caso de excepcion
            //}

            try
            {

                int valor = 10;
                Console.WriteLine(valor / 0);

            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);

            }

            try
            {

                string num = "a10";
                int valor1 = int.Parse(num);

            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);

            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);

            }

            try
            {

                string num = "9999999999";
                int valor = int.Parse(num);

            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);

            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);

            }
            catch (OverflowException e)
            {

                Console.WriteLine(e.Message);

            }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);

            }
            Console.ReadLine();


        }
    }
}
