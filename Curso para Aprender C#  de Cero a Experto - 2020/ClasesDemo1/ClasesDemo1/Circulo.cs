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

        public Circulo(int radioInicial)
        {

            radio = radioInicial;

        }

        public double CalcularArea()
        {

            return Math.PI * radio;

        }

    }
}
