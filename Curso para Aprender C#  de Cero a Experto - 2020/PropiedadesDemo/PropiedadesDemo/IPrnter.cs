using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDemo
{
    interface IPrnter
    {
        int GetX();
        void SetX(int value);

        int Y { get; set; }

    }
}
