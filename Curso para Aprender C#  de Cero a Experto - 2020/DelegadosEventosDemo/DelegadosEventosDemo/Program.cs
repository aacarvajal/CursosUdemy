using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventosDemo
{
    class Program
    {

        //static void Accion1(int n1, int n2, int n3, int n4){}

        //static string Funcion1()
        //{

        //    return "hola";

        //}

        //static string Funcion1(string s1, int i1, bool b1)
        //{

        //    return "hola";

        //}

        static void Main(string[] args)
        {

            //List<string> name = new List<string>
            //{

            //    "asdh",
            //    "asdf",
            //    "asdfg"

            //};

            //Predicate<string> predicado = new Predicate<string>(Contiene);//solo devuelve un valor boolean y recibe un tipo generico

            //var resultado = name.Find(predicado);
            //var existe = name.Exists(x => x.StartsWith("S"));

            CentralHub ch = new CentralHub();

            SistemaAlarmas alarmas = new SistemaAlarmas();
            SistemaLuces luces = new SistemaLuces();
            SistemaElectrodomesticos elect = new SistemaElectrodomesticos();

            //ch.Add(ApagarLuces);
            ch.Add(() => luces.ApagarLuces(5));
            ch.Add(alarmas.EncenderAlarmas);
            ch.Add(elect.ApagarElectrodomesticos);

            ch.Salida();
            ch.Salida();
            ch.Salida();
            ch.Salida();
            ch.Salida();

            //ch.IniciarProtocoloCierre();

            //Console.WriteLine(resultado);
            //Console.WriteLine(existe);

            //Delegado Action

            //SistemaLuces luces = new SistemaLuces();

            //Action a = new Action(luces.ApagarLuces);
            //Action<int, int, int, int> a2 = new Action<int, int, int, int>(Accion1);

            //Func<string> f1 = new Func<string>(Funcion1);
            //Func<string, int, bool> f2 = new Func<string, int, bool>(Funcion1);

            //List<int> num = new List<int>
            //{

            //    20,
            //    30,
            //    40,
            //    50,
            //    60

            //};

            //var promedio = num.Average();//promedio
            //var cuenta = num.Count(x => x > 50 && x < 100);
            //var suma = num.Sum(x => x % 2 == 0 ? x : 0);

            Console.ReadLine();

        }

        static void ApagarLuces()
        {

            SistemaLuces luces = new SistemaLuces();
            luces.ApagarLuces(2);

        }

        static bool Contiene(string name)
        {

            return name.Contains("H");

        }

    }
}
