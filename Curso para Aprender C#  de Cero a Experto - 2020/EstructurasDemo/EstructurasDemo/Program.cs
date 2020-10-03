using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //si no se inicializa dara fallo en el metodo print
            //Point? p = new Point();

            //Print(p);

            //Console.WriteLine();

            //StructPoint sp1 = new StructPoint();
            //StructPoint sp2 = sp1;

            //Console.WriteLine(sp1.x);
            //Console.WriteLine(sp2.x);

            //sp1.x++;

            //Console.WriteLine(sp1.x);
            //Console.WriteLine(sp2.x);

            ClassPoint cp1 = new ClassPoint();
            ClassPoint cp2 = cp1;

            Console.WriteLine(cp1.x);
            Console.WriteLine(cp2.x);

            cp1.x++;

            Console.WriteLine(cp1.x);
            Console.WriteLine(cp2.x);

            Console.ReadLine();

        }

        //static void Print(Point? p)
        //{

        //    Console.WriteLine(p.Value.x);

        //}

    }
}
