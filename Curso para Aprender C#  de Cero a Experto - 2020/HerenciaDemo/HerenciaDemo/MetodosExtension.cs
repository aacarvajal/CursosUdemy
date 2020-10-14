using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    static class MetodosExtension
    {

        public static int ContarPalabras(this string cadena, char caracter)//referencia al objeto con this antes del tipo
        {

            var palabras = cadena.Split(caracter);
            return palabras.Length;

        }

    }
}
