using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    sealed class Circulo : FiguraBase, IFigura, IRenderizador
    {//no permite herencias por parte de la clase

        int radio;

        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        public double CalcularArea()
        {
            throw new NotImplementedException();
        }

        void IFigura.Dibujar()
        {
            Console.WriteLine("Dibujando circulo");
        }

        public void Renderizar()
        {
            throw new NotImplementedException();
        }

        void IRenderizador.Dibujar()
        {
            throw new NotImplementedException();
        }

        public override void ObtenerTop()
        {
            throw new NotImplementedException();
        }
    }
}
