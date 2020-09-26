using System;

namespace MetodosDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Hello World!");

            Console.SetWindowSize(20, 20);

            Console.ReadLine();

            Console.Clear();

            Console.Beep();

            Console.ReadLine();*/

            /*Console.WriteLine("Hello World!");
            
            methodExample();

            Console.WriteLine(2+5);
            methodExample();*/

            string campo = Console.ReadLine();

            Saludar(campo);

            Console.ReadLine();

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

    }
}
