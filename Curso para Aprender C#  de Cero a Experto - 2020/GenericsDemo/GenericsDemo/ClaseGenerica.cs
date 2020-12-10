using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{

    interface IInterface<T>
    {
        T dato { get; set; }
    }

    struct EstructuraGenerica<T>
    {
        T dato;
    }

    public interface IHacerAlgo
    {

        string HacerAlgo();

    }

    class ClaseGenerica<T,U> where T : IHacerAlgo
    {

        T dato;
        U dato2;

        public ClaseGenerica(T datos)
        {
            dato = datos;
        }

        public void HacerAlgo(T parametro)
        {

            //T dato = parametro;
            //return dato;
            Console.WriteLine(parametro.HacerAlgo());

        }

    }
}
