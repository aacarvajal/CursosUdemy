using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo1
{
    class Circulo
    {

        int radio;
        public static int numCirc;
        public const double PI = 3.14;

        public Circulo(int radioInicial)
        {

            radio = radioInicial;
            numCirc++;

        }

        public double CalcularArea()
        {

            return Math.PI * radio;

        }

    }
}
