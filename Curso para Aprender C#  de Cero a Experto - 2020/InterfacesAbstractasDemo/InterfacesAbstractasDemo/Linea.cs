﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class Linea : IFigura
    {

        double pXi;
        double pYi;
        double pXf;
        double pYf;

        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        public double CalcularArea()
        {
            throw new NotImplementedException();
        }

        public void Dibujar()
        {
            throw new NotImplementedException();
        }
    }
}
