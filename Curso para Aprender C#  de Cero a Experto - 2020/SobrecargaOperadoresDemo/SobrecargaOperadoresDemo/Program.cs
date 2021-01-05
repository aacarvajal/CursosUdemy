using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadoresDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Circulo c = new Circulo();

            Rectangulo r = new Rectangulo();

            Console.WriteLine(r.Area);

            r = c;

            Console.WriteLine(r.Area);

            //var res1 = c + r;
            //var res2 = c + 2;
            //var res3 = 3 + c;

            //c += c;

            //c++;

            //Console.WriteLine(c.Area);
            //c++;
            //Console.WriteLine(c.Area);

            //HacerAlgo((int) 3.5);

            Console.ReadLine();

        }

        //static void HacerAlgo(double valor)
        //{

        //}

        static void HacerAlgo(int valor)
        {

        }

    }

    public abstract class Figura
    {

        public double Area { get; set; }
        public abstract void CalcularArea();

        public Figura()
        {

            CalcularArea();

        }

        public static double operator +(Figura lhs, Figura rhs) => lhs.Area + rhs.Area;

        public static double operator +(Figura lhs, int rhs) => lhs.Area + rhs;

        public static double operator +(int lhs, Figura rhs) => lhs + rhs.Area;

    }

    public class Circulo : Figura
    {
        public override void CalcularArea()
        {
            Area = 60;
        }

        public static Circulo operator +(Circulo lhs, Circulo rhs) => 
            new Circulo { Area = lhs.Area + rhs.Area };

        public static Circulo operator ++(Circulo c)
        {

            c.Area++;
            return c;

        }

        public static bool operator ==(Circulo lhs, Circulo rhs) => lhs.Area == rhs.Area;

        public static bool operator !=(Circulo lhs, Circulo rhs) => lhs.Area != rhs.Area;

        public static bool operator <=(Circulo lhs, Circulo rhs) => lhs.Area <= rhs.Area;

        public static bool operator >=(Circulo lhs, Circulo rhs) => lhs.Area >= rhs.Area;

        public static implicit operator Rectangulo(Circulo c) => 
            new Rectangulo { Area = c.Area};

    }

    public class Rectangulo : Figura
    {
        public override void CalcularArea()
        {
            Area = 100;
        }

    }

}
