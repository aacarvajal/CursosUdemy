using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores_Demo
{

    class Bits3 : Bits2
    {

        public override bool this[int index] 
        {
            get => base[index]; 
            set => base[index] = value; 
        }

    }

    class Bits2 : IIndexadorBase
    {
        public virtual bool this[int index]
        {//podran sobrescribir la funcionalidad de bits2

            get => throw new NotImplementedException();

            set => throw new NotImplementedException();

        }
    }

    interface IIndexadorBase
    {

        bool this[int index] { get; set; }

    }
}
