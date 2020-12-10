using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pila p = new Pila(3);
            //p.Apilar(1);
            //p.Apilar(2);
            //p.Apilar("hola");

            //object elemento = p.Desapilar();

            //Console.WriteLine(elemento);

            //elemento = p.Desapilar();

            //Console.WriteLine(elemento);

            //elemento = p.Desapilar();

            //Console.WriteLine(elemento);

            //Circulo c = new Circulo();

            //p.Apilar(c);
            ////elemento = p.Desapilar();
            //Circulo c2 = (Circulo) p.Desapilar();
            //Console.WriteLine(c2);

            ClaseGenerica<ArgumentOutOfRangeException, string> cg = 
                new ClaseGenerica<ArgumentOutOfRangeException, string>(new ArgumentOutOfRangeException());
            //cg.HacerAlgo(3);
            ClaseGenerica<Exception,Circulo> cg2 = 
                new ClaseGenerica<Exception, Circulo>(new Exception("hola"));
            //cg2.HacerAlgo("hola");

            Console.ReadLine();

        }
    }
}
