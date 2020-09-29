using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones2Demos
{
    class Program
    {
        static void Main(string[] args)
        {

            int entero = int.MaxValue;

            //checked
            //{

            //    entero++;//comprueba la posible excepcion

            //}

            //entero = unchecked(entero++);

            //Console.WriteLine(entero);

            int mes = int.Parse(Console.ReadLine());

            try
            {

                Console.WriteLine(Zodiaco(mes));

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            finally
            {

                Console.WriteLine("Relleno");

            }
            

            Console.ReadLine();

        }

        static string Zodiaco(int num)
        {

            string res = string.Empty;

            switch (num)
            {

                case 1:
                    res = "Aries";
                    break;
                case 2:
                    res = "Tauro";
                    break;
                case 3:
                    res = "Geminis";
                    break;
                case 4:
                    res = "Cancer";
                    break;
                case 5:
                    res = "Leo";
                    break;
                case 6:
                    res = "Virgo";
                    break;
                case 7:
                    res = "Libra";
                    break;
                case 8:
                    res = "Escorpio";
                    break;
                case 9:
                    res = "Sagitario";
                    break;
                case 10:
                    res = "Capricornio";
                    break;
                case 11:
                    res = "Acuario";
                    break;
                case 12:
                    res = "Piscis";
                    break;
                default:
                    throw new InvalidOperationException("MAL");
                    break;
            }

            return res;

        }
    }
}
