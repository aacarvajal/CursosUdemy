using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposValorTiposReferencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //int v1 = 50;
            //int v2 = v1;

            //Console.WriteLine(v1);
            //Console.WriteLine(v2);

            //v1++;

            //Console.WriteLine(v1);
            //Console.WriteLine(v2);

            //Circulo c1 = new Circulo();

            //c1.radio = 50;

            //Circulo c2 = c1;

            //Console.WriteLine(c1.radio);
            //Console.WriteLine(c2.radio);

            //c1.radio = 20;

            //Console.WriteLine(c1.radio);
            //Console.WriteLine(c2.radio);

            //int n1 = 0;
            //Agregar(n1);

            //Circulo c1 = new Circulo();

            //c1.radio = 10;

            //Agregar(c1);

            //NULLS
            //Circulo c1 = null;
            //Circulo c1 = new Circulo();

            //if(c1 != null)
            //{

            //    //c1 = new Circulo();
            //    //c1.radio = 40;
            //    Console.WriteLine(c1.radio);

            //}

            //Console.WriteLine(c1?.radio);//lo mostrara si no es igual a nulo (? operador null condicional)
            //? sirve para comprobar si la variable de la izquierda esta inicializada

            //int? i = null;//poniendo ? despues del tipo, no hay problemas al poner una variable a null (tipo nullable)

            //i = 10;

            //int? j = 0;

            //j = i;//no se puede convertir un tipo nullable en int

            //if (!i.HasValue)//nos dice si la variable es nula o tiene algo especificado
            //{

            //    i = 10;//si no tiene un valor especificado se le da ese valor

            //}
            //else
            //{

            //    Console.WriteLine(i.Value);//lo mostrara si ya tiene valor

            //}

            //int n = 10;

            //Agregar(ref n);//indica donde se puede estar haciendo la modificacion directa

            //int n2;
            //Agregar(out n2);

            //int.TryParse("50", out int p1);

            //Console.WriteLine(p1);

            //SYSTEM.OBJECT
            //object entero = 13;
            //object cadena = "asd";
            //object cir = new Circulo();

            //boxing unboxing

            //int valor = 50;
            //object objeto = valor;
            //int v2 = (int)objeto;

            //Console.WriteLine(v2);

            //IS y AS

            int valor = 50;
            object objeto = "asd";

            //is compara en condificionales como IF

            if(objeto is int)
            {

                //IS comprueba si la variable es del tipo especificado
                Console.WriteLine(objeto);

            }
            else if(/*objeto is string*/ objeto is Circulo)
            {

                Circulo c1 = (Circulo)objeto;
                //IS comprueba si la variable es del tipo especificado
                Console.WriteLine(c1.radio);//saltaria este al contener un texto

            }

            //as cambia la variable al tipo de dato que uno quiere

            string v2 = objeto as string;

            //si no contiene texto, lo devolvera vacio
            if(v2 != null)
            {

                Console.WriteLine(v2);

            }

            Console.ReadLine();

        }

        public static void Agregar(out int p1)//se pasa la referencia de la variable y no una copia
        {//con out se inicializa la variable dentro para que no haya que inicializarlo fuera

            p1 = 0;
            p1++;

        }

        public static void Agregar(Circulo c1)
        {

            //mientras no devuelva un dato, el valor aqui asignado no lo devolvera, por lo que seguira
            //cogiendo el valor dado de la variable anterior a la invocacion del metodo
            c1 = new Circulo();

            c1.radio = 50;

            //c1.radio++;

        }

    }
}
