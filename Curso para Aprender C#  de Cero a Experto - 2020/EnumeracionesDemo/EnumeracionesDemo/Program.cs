using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracionesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Administrador - 1
            //Desarrollador - 2
            //Usuario final - 3

            Rol tipoUsuario = Rol.Administrador;

            Console.WriteLine((int)tipoUsuario);

            if (tipoUsuario == Rol.Administrador)
            {

                tipoUsuario++;

            }

            Rol? tu2 = null;

            string temporal = tipoUsuario.ToString();

            switch (tipoUsuario)
            {
                case Rol.Administrador:
                    Console.WriteLine("Admin");
                    break;
                case Rol.Desarrollador:
                    Console.WriteLine("Develop");
                    break;
                case Rol.UsuarioFinal:
                    Console.WriteLine("Final User");
                    break;
            }

            Console.ReadLine();

        }

        public static void Validar(Rol r)
        {



        }

    }
}
