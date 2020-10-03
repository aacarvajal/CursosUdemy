using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDemo
{
    struct StructPoint
    {

        //una estructura es un tipo por valor y se copia en el stack (pila)
        //una clase solo copia la referencia y ambas referencias apuntando al mismo objeto

        public int x;
        public int y;

        //no se puede declarar un constructor por defecto (vacio)porque el compilador siempre genera un parametro
        //al contrario que en una clase, que lo genera si no has creado tu mismo uno
        //siempre especifica 3 posibles valores para la estructura (0,false y null)
        //si no se inicializan todas las variables, marcara un fallo en la variable faltante

        //en una clase se puede declarar una variable desde su definicion, mientras que en una estructura no
        //public Point(int x, int y)
        //{

        //    this.x = x;
        //    this.y = y;

        //}

        //public int Calcular()
        //{

        //    return x * y;

        //}

    }

    class ClassPoint
    {

        public int x;
        public int y;

    }
}
