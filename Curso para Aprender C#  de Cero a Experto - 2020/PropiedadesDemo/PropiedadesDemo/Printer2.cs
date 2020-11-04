using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesDemo
{

    /*class PrinterDerivada : Printer2
    {

        public override int GetX()
        {
            return base.GetX();
        }

        public override void SetX(int value)
        {
            base.SetX(value);
        }

    }*/

    class Printer2 : IPrnter
    {
        int IPrnter.GetX()
        {
            throw new NotImplementedException();
        }

        void IPrnter.SetX(int value)
        {
            throw new NotImplementedException();
        }

        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
