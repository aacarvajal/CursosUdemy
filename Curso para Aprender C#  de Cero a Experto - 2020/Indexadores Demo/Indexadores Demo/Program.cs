using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //uint binData = 0b01111;//representacion de valores binarios en enteros
            //uint binData2 = 0x0_f;//representacion de valores hexadecimales

            //Console.WriteLine(Convert.ToString(binData, 2));//convertir numero a binario
            //Console.WriteLine(Convert.ToString(binData2, 16));//convertir numero a hexadecimal

            //uint binData = 0b0_00000000_00000000_00000000_10001111;
            //uint binData2 = 0b0_00000000_00000000_00000000_00001111;
            //NOT
            //uint result = ~binData;
            //con "~" se negara el valor de la variable, lo que quiere decir que pondra el valor contrario

            //LEFT SHIT "<<"
            //right shit ">>"
            //uint result = binData << 2;//se desplazara el valor dos puestos hacia la izq

            //OR
            //uint result = binData | binData2;

            //AND 
            //uint result = binData & binData2;

            //xor - or exclusivo (devuelve 0 si el valor de la posicion coincide en las dos variables)
            //devuelve un valor 1 en los bits en el que hay un 1, la posicion del valor 1 no coincidira
            //uint result = binData ^ binData2;

            //Console.WriteLine(Convert.ToString(result, 2));

            int binData = 0b0_00000000_00000000_00000000_10000000;

            //var uno = 0b0_00000001;
            //var desplazamiento = uno << 7;
            //var result = (binData & desplazamiento) != 0;
            //var result = (binData & (1 << 7)) != 0;

            //Console.WriteLine(result);

            Bits b = new Bits(binData);

            HacerAlgo(b[3]);

            bool dato = b[0];

            b["prueba"] = 2;

            Console.WriteLine(dato);

            b[0] = true;

            dato = b[0];

            Console.WriteLine(dato);

            Console.ReadLine();

            //un indexador puede usar subindices no numericos como cadenas 
            //los arreglos solo pueden usar subindices enteros

        }

        static void HacerAlgo(ref bool valor)
        {
            
        }

    }
}
