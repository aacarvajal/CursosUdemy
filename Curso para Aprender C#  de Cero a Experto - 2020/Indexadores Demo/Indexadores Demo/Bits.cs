using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores_Demo
{
    struct Bits
    {

        int bits;

        public Bits(int inicialBits)
        {

            bits = inicialBits;

        }

        public int this[string cadena]
        {

            get { return 1; }
            set { }

        }

        public bool this[int index]
        {

            get => (bits & (1 << index)) != 0;

            set
            {

                if (value)
                {

                    bits |= (1 << index);

                }
                else
                {

                    bits &= ~(1 << index);
                    //pondra un valor 0

                }

            }

        }

        public override string ToString()
        {
            return (Convert.ToString(bits, 2));
        }

    }
}
