using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //interfaz IEnumerable
            List<string> lista = new List<string>();
            Stack<string> pila = new Stack<string>();

            ClientesManager cm = new ClientesManager();

            //foreach (Cliente item in cm)
            //{

            //    Console.WriteLine(item.Nombre);

            //}

            //interfaz IEnumerator

            var enumerator = cm.GetEnumerator();

            while (enumerator.MoveNext())
            {

                Console.WriteLine(((Cliente)enumerator.Current).Nombre);

            }

            //Un enumerador utilizando iteradores
            //un iterador es una descripcion de la secuencia de enumeracion que puede usar para crear su propìo enumerador

            Console.ReadLine();

        }
    }
}
