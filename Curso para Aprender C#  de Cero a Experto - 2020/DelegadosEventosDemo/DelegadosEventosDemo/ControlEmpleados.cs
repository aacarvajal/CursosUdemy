using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventosDemo
{
    class ControlEmpleados
    {

        //public delegate void iniciarProtocoloDelegate();

        public event Action EmpleadoCero;

        int numEmpleado = 5;

        public void Salida()
        {

            numEmpleado--;
            if (numEmpleado == 0)
            {

                if(EmpleadoCero != null)
                {

                    EmpleadoCero();

                }

            }
            else
            {

                Console.WriteLine($"Quedan {numEmpleado} empleados");

            }

        }

    }
}
