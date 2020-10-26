using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionRecursosDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            using(FileManager fm = new FileManager(@"C:\Users\Adrian\Documents\prueba.txt"))
            {
            }

            using (FileManager fm2 = new FileManager(@"C:\Users\Adrian\Documents\prueba.txt"))
            {
            }

            //FileManager fm = new FileManager(@"C:\Users\Adrian\Documents\prueba.txt");
            //FileManager fm2 = new FileManager(@"C:\Users\Adrian\Documents\prueba.txt");

            Console.ReadLine();

        }
    }
}
