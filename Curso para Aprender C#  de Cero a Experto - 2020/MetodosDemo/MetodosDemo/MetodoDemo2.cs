using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosDemo
{
    class MetodoDemo2
    {

        static void Main(string[] args)
        {

            /*int cociente = 0;
            int resto = 0;

            (cociente, resto) = Dividir(50, 25);

            Console.WriteLine(cociente);
            Console.WriteLine(resto);

            (int cociente, int resto) data = Dividir(50, 25);

            Console.WriteLine(data);

            Saludar();

            Multiplicar(2,3);*/

            Console.WriteLine(CalcularCuenta(100, 10, 3, iva : 20));
            //Console.WriteLine(CalcularCuenta(100, 10, 3, 50));

            EscribirTexto("df");

            Console.ReadLine();

        }

        static void EscribirTexto(string texto)
        {

            Console.WriteLine(texto);

            Limpiar();

            void Limpiar()
            {

                Console.ReadLine();
                Console.Clear();
                Console.Beep();

            }

        }

        static int Multiplicar(int n1, int n2)
        {

            return n1 * n2;

        }

        static double Multiplicar(double n1, int n2)
        {

            return n1 * n2;

        }

        /*static double CalcularCuenta(double cuenta, double propina, int comensales)
        {

            return (cuenta + propina) / comensales;

        }*/

        static double CalcularCuenta(double cuenta, double propina, int comensales, double estacionamiento = 0,
            double iva = 5)
        {

            return (cuenta + propina + estacionamiento + iva) / comensales;

        }

        static void Saludar() => Console.WriteLine("asd");

        static (int, int) Dividir(int n1, int n2)
        {

            int cociente = n1 / n2;
            int resto = n1 % n2;

            return (cociente, resto);

        }

        static (int, int) DevolverDatos()
        {

            return (9, 4);

        }

    }
}
