using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDemo
{
    class Printer
    {

        int x;
        int y;

        public Printer(int x, int y)
        {

            this.x = VerificarX(x);
            this.y = VerificarY(y);

        }

        public void Print()
        {

            Console.SetCursorPosition(x, y);

            Console.WriteLine("X");

        }

        private int VerificarX(int x)
        {

            if (x < 0 || x > 50)
            {
                throw new ArgumentOutOfRangeException("error en X");
            }

            return x;

        }

        private int VerificarY(int x)
        {

            if (y < 0 || y > 60)
            {
                throw new ArgumentOutOfRangeException("error en Y");
            }

            return y;

        }

        public int ObtenerX()
        {

            return x;

        }
        public int ObtenerY()
        {

            return y;

        }

        public void AsignarX(int x)
        {

            this.x = VerificarX(x);

        }

        public void AsignarY(int y)
        {

            this.y = VerificarX(y);

        }

    }
}
