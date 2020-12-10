using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Pila<T>
    {

        int tamanioDefault = 100;
        //int[] arreglo;
        T[] arreglo;
        int indiceActual = 0;
        int numElements = 0;

        public Pila()
        {

            arreglo = new T[tamanioDefault];

        }

        public Pila(int _tamanio)
        {

            if(_tamanio > 0)
            {

                arreglo = new T[_tamanio];

            }
            else
            {

                throw new ArgumentOutOfRangeException("El tamaño debe ser mayor a 0");

            }

        }

        public void Apilar(T elemento)
        {

            if(numElements == arreglo.Length)
            {

                throw new Exception("El array esta lleno");

            }
            arreglo[indiceActual] = elemento;
            indiceActual++;
            numElements++;

        }

        public T Desapilar()
        {

            if (numElements == 0)
            {

                throw new Exception("El array esta vacio");

            }

            indiceActual--;
            T elemento = arreglo[indiceActual];
            numElements--;
            return elemento;

        }

    }
}
