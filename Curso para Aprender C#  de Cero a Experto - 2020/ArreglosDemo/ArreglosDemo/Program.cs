using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //var v = new[] { "asd", "ads" };

            //var personas = new[]
            //{

            //    new{Nombre = "Hector"},
            //    new{Nombre = "Adrian"}

            //};

            //Circulo[] c = { new Circulo(20), new Circulo(22), new Circulo(2) };

            //int[] n = new int[4] { 1, 2, 3, 4 };//asi
            //int[] n = { 1, 2, 3, 4 };//o asi

            //try
            //{

            //    int n3 = n[2];

            //    Console.WriteLine(n3);

            //}
            //catch (IndexOutOfRangeException ind)
            //{

            //    Console.WriteLine(ind.Message);
            //}

            //int[] n = { 1, 2, 3, 4 };

            //for (int i = 0; i < n.Length; i++)
            //{

            //    Console.WriteLine(n[i]);

            //}

            //foreach (var num in n)
            //{

            //    Console.WriteLine(num);

            //}

            //var datos = Inicializar();

            //if (args.Length > 0)
            //{

            //    foreach (var param in args)
            //    {

            //        Console.WriteLine(param);

            //    }

            //}

            //int[] array = { 1, 2, 3 };

            //int[] array2 = new int[array.Length];

            //hay varias formas de copiar todo el contenido de los arrays
            //usando el metodo copy dentro de la clase array
            //Array.Copy(array, array2, array.Length);

            //clonando el array completo, aunque asi no se puede controlar el tamaño del array
            //int[] array3 = (int[])array.Clone();

            //o con un bucle for
            //for (int i = 0; i < array.Length; i++)
            //{

            //    array2[i] = array[i];

            //}

            //Console.WriteLine(array[0]);
            //Console.WriteLine(array2[0]);

            //array[0] = 50;

            //Console.WriteLine(array[0]);
            //Console.WriteLine(array2[0]);

            int[,] bidimen = new int[5, 5];

            bidimen[0, 0] = 1;

            Console.ReadLine();

        }

        static void GenerarInforme(int[] datos)
        {



        }

        static int [] Inicializar()
        {

            Console.WriteLine("Numero de elementos: ");

            string respuesta = Console.ReadLine();

            int cantidad = int.Parse(respuesta);

            int[] num = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {

                Console.WriteLine("Valor para el elemento");

                respuesta = Console.ReadLine();

                int dato = int.Parse(respuesta);

                num[i] = dato;

            }

            return num;

        }

    }
}
