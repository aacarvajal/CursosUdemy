using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemos
{
    class Program
    {
        static void Main(string[] args)
        {

            var estudiantes = new[]
{
                new
                {
                    EstudianteID = 1,
                    Nombre = "Héctor",
                    ApellidoPaterno = "Pérez",
                    Universidad = "Real de Brasil"
                },
                new
                {
                    EstudianteID = 2,
                    Nombre = "Ana",
                    ApellidoPaterno = "Nepomuceno",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 3,
                    Nombre = "Pedro",
                    ApellidoPaterno = "Sánchez",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 4,
                    Nombre = "José",
                    ApellidoPaterno = "Infante",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 5,
                    Nombre = "Regina",
                    ApellidoPaterno = "Bustamante",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 6,
                    Nombre = "Rodrigo",
                    ApellidoPaterno = "Jiménez",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 7,
                    Nombre = "Miguel",
                    ApellidoPaterno = "Hernández",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 8,
                    Nombre = "Marilyn",
                    ApellidoPaterno = "Monroe",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 9,
                    Nombre = "Leonardo",
                    ApellidoPaterno = "Estrada",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 10,
                    Nombre = "Ricardo",
                    ApellidoPaterno = "Rojas",
                    Universidad = "Real de Brasil"
                },
            };

            var universidades = new[]
            {
                new
                {
                    Universidad = "Real de Brasil",
                    Ciudad = "Brasilia",
                    Pais = "Brasil"
                },
                new
                {
                    Universidad = "Oxford",
                    Ciudad = "Oxford",
                    Pais = "Reino Unido"
                },
                new
                {
                    Universidad = "Harvard",
                    Ciudad = "Cambridge",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "Brooklyn",
                    Ciudad = "Nueva York",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "UNAM",
                    Ciudad = "Ciudad de México",
                    Pais = "México"
                },
            };

            //IEnumerable<string> nomEst = estudiantes.Select(e => $"{e.Nombre} {e.ApellidoPaterno}");

            //foreach (var item in nomEst)
            //{

            //    Console.WriteLine(item);

            //}

            //var nomEst = estudiantes.Select(e => new
            //{

            //    Nombre = e.Nombre,
            //    Apellido = e.ApellidoPaterno

            //});

            //var nomEst = from nombres in estudiantes select nombres.Nombre;
            //var nomEst = from nombres in estudiantes select new { nombres.Nombre, nombres.ApellidoPaterno};

            //foreach (var item in nomEst)
            //{

            //    Console.WriteLine(item);

            //}

            //foreach (var item in nomEst)
            //{

            //    Console.WriteLine(item);

            //}

            //var uniEU = universidades
            //    .Where(u => u.Pais == "Estados Unidos")
            //    .Select(u => u.Universidad);

            //var uniEU = from u in universidades 
            //            where string.Equals(u.Pais, "Estados Unidos") select u.Universidad;

            //foreach (var item in uniEU)
            //{

            //    Console.WriteLine(item);

            //}

            //foreach (var item in uniEU)
            //{

            //    Console.WriteLine(item);

            //}

            //IEnumerable<string> nomUni = universidades
            //    .OrderBy(u => u.Universidad)
            //    .Select(u => u.Universidad);

            //var nomUni = from u in universidades orderby u.Universidad select u.Universidad;

            //foreach (var item in nomUni)
            //{

            //    Console.WriteLine(item);

            //}

            //var uniPais = universidades.GroupBy(u => u.Pais);

            //var uniPais = from u in universidades group u by u.Pais;

            //foreach (var grupo in uniPais)
            //{

            //    Console.WriteLine($"Universidad: {grupo.Key} \t {grupo.Count()}");
            //    foreach (var item in grupo)
            //    {

            //        Console.WriteLine($"\t {item.Universidad}");

            //    }

            //}

            //int numUni = universidades.Select(x => x.Universidad).Count();//5

            //int numUni = (from u in universidades select u.Universidad).Count();

            //int numPais = universidades.Select(x => x.Pais).Distinct().Count();//4

            //Console.WriteLine(numUni);

            //var join = estudiantes.Select(e => new
            //{

            //    e.Nombre,
            //    e.ApellidoPaterno,
            //    e.Universidad

            //})
            //    .Join(universidades,
            //    est => est.Universidad,
            //    u => u.Universidad,
            //    (e, u) => new { e.Nombre, e.ApellidoPaterno, u.Pais });

            //var join = from u in universidades
            //           join e in estudiantes
            //           on u.Universidad equals e.Universidad
            //           select new { e.Nombre, e.ApellidoPaterno, u.Pais };

            //foreach (var item in join)
            //{

            //    Console.WriteLine(item);

            //}

            //var parte = estudiantes.Skip(1).Take(2);

            //foreach (var item in parte)
            //{

            //    Console.WriteLine(item);

            //}

            //var cualquier = estudiantes.Any(x => x.Nombre.StartsWith("A"));

            //var todos = estudiantes.All(x => x.Nombre != "");

            //var primero = estudiantes.First(x => x.Nombre.StartsWith("A"));
            //var primero = estudiantes.FirstOrDefault(x => x.Nombre.StartsWith("A"));//devuelve nulo si no encuentra el valor

            //if (primero != nulll)
            //{
            //}

            var estNom = estudiantes.Select(x => x.Nombre);

            foreach (var item in estNom)
            {

                Console.WriteLine(item);

            }

            estudiantes[0] = new
            {
                EstudianteID = 1,
                Nombre = "A",
                ApellidoPaterno = "D",
                Universidad = "Harvard"
            };

            foreach (var item in estNom)
            {

                Console.WriteLine(item);

            }

            Console.ReadLine();

        }
    }

    //class NombreCompleto
    //{

    //    public string Nombre { get; set; }
    //    public string Apellido { get; set; }

    //}

}
