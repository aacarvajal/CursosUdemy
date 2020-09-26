using System;

namespace MetodosDemo
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Hello World!");

            Console.SetWindowSize(20, 20);

            Console.ReadLine();

            Console.Clear();

            Console.Beep();

            Console.ReadLine();

            Console.WriteLine("Hello World!");
            
            methodExample();

            Console.WriteLine(2+5);
            methodExample();

            string campo = Console.ReadLine();

            Saludar(campo);

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(SumarReturn(n1, n2));

            Console.ReadLine();

        }*/

        static void Sumar(int n1, int n2)
        {

            Console.WriteLine(n1 + n2);

        }

        static int SumarReturn(int n1, int n2)
        {

            return n1 + n2;

        }

        static void Saludar(string campo)
        {

            Console.WriteLine("Hello World! " + campo);

        }

        public static void methodExample()
        {

            Console.ReadLine();
            Console.Clear();
            Console.Beep();

        }

        static void Saludar() => Console.WriteLine("Hello World!");
        static int Sumar2(int n1, int n2) => n1+n2;

    }
}
