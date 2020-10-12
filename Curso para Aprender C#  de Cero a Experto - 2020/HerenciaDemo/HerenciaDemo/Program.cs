using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //MultimediaFile mf = new MultimediaFile("12/12/08","12/12/08", "nuevo archivo1", "video3");

            MultimediaFile mf = new MultimediaFile();

            Console.WriteLine(mf.ToString());

            //mf.DesplegarInfor();

            //DynamicFile df = new DynamicFile("12/12/08", "12/12/08", "nuevo archivo2", "video2");

            DynamicFile df = new DynamicFile();

            df.DesplegarInfor();

            //df.DesplegarInfor();

            //StaticFile sf = new StaticFile("12/12/08", "12/12/08", "nuevo archivo3", "video1");

            StaticFile sf = new StaticFile();

            sf.DesplegarInfor();

            //sf.Editar();

            //sf.DesplegarInfor();

            /*MultimediaFile mf1 = sf;

            StaticFile sf2 = mf1 as StaticFile;

            if(mf1 != null)
            {
                sf2.DesplegarInfor();
            }*/

            Console.ReadLine();

        }
    }
}
