using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            ////CLASE COLECCION <T>

            //int[] num = new int[10];
            //num[2] = 20;


            //List<int> numList = new List<int>();
            //numList.Add(20);

            //for(int i=1; i <= 10; i++)
            //{

            //    numList.Add(i);

            //}

            //numList.Insert(numList.Count - 1, 50);//en el penultimo valor, un valor de 50
            //numList.Remove(9);//borra el numero 9
            //numList.RemoveAt(8);//borra un numero de una posicion especifica
            //numList.RemoveRange(0, 3);//borra los numeros que hay entre dos posiciones
            //numList.Clear();//limpia la lista

            //int numero = numList[0];

            //foreach (var item in numList)
            //{

            //    Console.WriteLine(item);

            //}

            ////CLASE COLECCION LinkedList<T>

            //LinkedList<int> num = new LinkedList<int>();
            ////num.AddLast(3);

            //for (int i = 0; i < 10; i++)
            //{

            //    //num.AddLast(i);
            //    num.AddFirst(i);

            //}

            //var primero = num.AddFirst(100);

            //num.AddAfter(primero, 200);

            //num.AddBefore(primero, 140);

            //var nodo = num.First;

            //while (nodo!=null)
            //{

            //    Console.WriteLine(nodo.Value);
            //    nodo = nodo.Next;

            //}

            //for(var nodo2 = num.Last; nodo2!=null; nodo2 = nodo2.Previous)
            //{

            //    Console.WriteLine(nodo2.Value);

            //}

            //num.Remove(3);//borrar todos los numeros 
            //num.RemoveFirst();//borra el primer valor
            //num.RemoveLast();//borra el ultimo valor

            //foreach (var item in num)
            //{

            //    Console.WriteLine(item);

            //}

            //CLASE COLECCION Queue<T>//cola

            //Queue<int> num = new Queue<int>();
            ////num.Enqueue(3);//mete el valor en el primer lugar de la lista

            //for (int i = 0; i < 10; i++)
            //{

            //    num.Enqueue(i);

            //}

            //var elemento = num.Dequeue();

            //while (num.Count > 0)
            //{

            //    elemento = num.Dequeue();
            //    Console.WriteLine(elemento);

            //}

            //foreach (var item in num)
            //{

            //    Console.WriteLine(item);

            //}

            //CLASE COLECCION Stack<T>//pila

            //Stack<int> num = new Stack<int>();

            //for (int i = 0; i < 10; i++)
            //{

            //    num.Push(i);//insertar elemento

            //}

            //var elemento = num.Pop();//sacar un elemento de la pila

            //while (num.Count > 0)
            //{

            //    elemento = num.Pop();
            //    Console.WriteLine(elemento);

            //}

            //CLASE COLECCION Dictionary<T> //Diccionario generico

            //int[] num = new int[3] { 1, 2, 3 };

            //num[0] = 22;//array asociativo

            //Dictionary<int, int> d = new Dictionary<int, int>();

            //Dictionary<string, string> frase = new Dictionary<string, string>();

            //frase.Add("CP", "asdas");
            //frase.Add("CP1", "asdas1");
            //         //clave  //valor
            //foreach (var item in frase)
            //{

            //    string c = item.Key;
            //    string f = item.Value;
            //    Console.WriteLine($"{c}, {f}");//cadena interpolada

            //}

            //frase["CP1"] = "1234";

            //foreach (var item in frase)
            //{

            //    string c = item.Key;
            //    string f = item.Value;
            //    Console.WriteLine($"{c}, {f}");//cadena interpolada

            //}

            //for (int i = 0; i < 10; i++)
            //{

            //    d.Add(i,i);

            //}

            //CLASE COLECCION SortedList<T>//lista ordenada

            //SortedList<string, string> sl = new SortedList<string, string>();

            //sl.Add("Z", "Za");
            //sl.Add("A", "Aa");
            //sl.Add("B", "Bb");

            //foreach (var item in sl)
            //{

            //    string v1 = item.Key;
            //    string v2 = item.Value;
            //    Console.WriteLine($"{v1}:{v2}");

            //}

            //CLASE COLECCION HashSet<T>

            //HashSet<string> hs = new HashSet<string>();
            //hs.Add("cocina");
            //hs.Add("negocio");
            //hs.Add("otros");

            //HashSet<string> hs2 = new HashSet<string>(new string[] { "cocina", "negocio2", "otros" });

            //foreach (var item in hs)
            //{

            //    Console.WriteLine(item);

            //}

            //Console.WriteLine();

            ////hs.IntersectWith(hs2);
            ////hs.UnionWith(hs2);
            //hs.ExceptWith(hs2);

            //foreach (var item in hs)
            //{

            //    Console.WriteLine(item);

            //}

            Console.ReadLine();

        }
    }
}
