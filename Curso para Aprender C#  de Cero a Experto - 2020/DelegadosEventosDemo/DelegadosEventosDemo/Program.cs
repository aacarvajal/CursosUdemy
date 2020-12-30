using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventosDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> name = new List<string>
            {

                "asdh",
                "asdf",
                "asdfg"

            };

            Predicate<string> predicado = new Predicate<string>(Contiene);

            var resultado = name.Find(predicado);
            var existe = name.Exists(x => x.StartsWith("S"));

            //CentralHub ch = new CentralHub();

            //SistemaAlarmas alarmas = new SistemaAlarmas();
            //SistemaLuces luces = new SistemaLuces();
            //SistemaElectrodomesticos elect = new SistemaElectrodomesticos();

            //ch.Add(luces.ApagarLuces);
            //ch.Add(alarmas.EncenderAlarmas);
            //ch.Add(elect.ApagarElectrodomesticos);

            //ch.IniciarProtocoloCierre();

            Console.WriteLine(resultado);
            Console.WriteLine(existe);

            Console.ReadLine();

        }

        static bool Contiene(string name)
        {

            return name.Contains("H");

        }

    }
}
