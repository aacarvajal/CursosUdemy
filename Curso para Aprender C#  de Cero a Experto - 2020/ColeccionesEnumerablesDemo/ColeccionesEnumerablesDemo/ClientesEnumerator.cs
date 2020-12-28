using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerablesDemo
{
    class ClientesEnumerator : IEnumerator
    {

        int position = -1;
        List<Cliente> clientes = null;

        public ClientesEnumerator(List<Cliente> _clientes)
        {

            clientes = _clientes;

        }

        object IEnumerator.Current
        {

            get
            {

                try
                {

                    return clientes[position];

                }
                catch (IndexOutOfRangeException)
                {

                    throw new InvalidOperationException();
                }

            }

        }

        bool IEnumerator.MoveNext()
        {

            position++;
            return (position < clientes.Count);

        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
