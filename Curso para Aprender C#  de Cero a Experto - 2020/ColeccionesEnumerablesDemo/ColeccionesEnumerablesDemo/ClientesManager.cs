using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerablesDemo
{
    class ClientesManager : IEnumerable
    {

        List<Cliente> cli = new List<Cliente>()
        {

            new Cliente{ID = 1, Nombre="Adrian1"},
            new Cliente{ID = 2, Nombre="Adrian2"},
            new Cliente{ID = 3, Nombre="Adrian3"}

        };

        public IEnumerator GetEnumerator()
        {

            //return new ClientesEnumerator(cli);
            foreach (var item in cli)
            {

                yield return item;

            }

        }
    }
}
