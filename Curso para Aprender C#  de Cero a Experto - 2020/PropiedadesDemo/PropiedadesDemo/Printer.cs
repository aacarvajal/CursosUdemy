using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDemo
{
    class Printer
    {

        //public int Z { get; set; }//lectura/escritura
        //public int Z { get; } = 10;//solo lectura
        //no se puede poner unicamente un set, debe tener incluido get o solo llevar get
        //int z;
        //public int Z
        //{

        //    get { return z; }
        //    set { z = value; }

        //}

        public int Prueba//definicion de propiedades
        {

            get
            {

                return 1;

            }
            set
            {

                int temp = value;

            }

            //quitando el set, la propiedad seria de solo lectura
            //quitando el get, la propiedad seria de solo escritura
            //poniendo private se restringue el uso parcial de escritura o lectura, solo se puede cambiar uno de los dos

        }

        int x;
        int y;

        public int X
        {

            get => x;

            set => x = VerificarX(value);

        }

        public int Y
        {

            get => y;

            set => y = VerificarY(value);

        }

        public Printer(int x, int y)
        {

            this.x = VerificarX(x);
            this.y = VerificarY(y);
            //Z = 10;//solo se puede declarar en el construtor un valor de la propiedad si es de solo lectura

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

        //public int ObtenerX()
        //{

        //    return x;

        //}
        //public int ObtenerY()
        //{

        //    return y;

        //}

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
