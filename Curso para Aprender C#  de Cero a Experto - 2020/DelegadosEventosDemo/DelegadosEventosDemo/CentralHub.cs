using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventosDemo
{
    public class CentralHub
    {

        //un delegado es una referencia a un metodo

        ControlEmpleados ce = new ControlEmpleados();

        //iniciarProtocoloDelegate iniciarProtocolo;

        //SistemaAlarmas alarmas = new SistemaAlarmas();
        //SistemaLuces luces = new SistemaLuces();
        //SistemaElectrodomesticos elect = new SistemaElectrodomesticos();

        //public CentralHub()
        //{

        //    iniciarProtocolo += luces.ApagarLuces;//solo poner el nombre del metodo
        //    iniciarProtocolo += alarmas.EncenderAlarmas;//solo poner el nombre del metodo
        //    iniciarProtocolo += elect.ApagarElectrodomesticos;//solo poner el nombre del metodo

        //    iniciarProtocolo -= alarmas.EncenderAlarmas;

        //    //iniciarProtocolo = new iniciarProtocoloDelegate(luces.ApagarLuces);

        //}

        //public void IniciarProtocoloCierre()
        //{

        //    //luces.ApagarLuces();
        //    //alarmas.EncenderAlarmas();
        //    //elect.ApagarElectrodomesticos();
        //    iniciarProtocolo();//es un apuntador a uno o varios metodos

        //}

        public void Add(Action metodoProtocolo) => ce.EmpleadoCero += metodoProtocolo;

        public void Remove(Action metodoProtocolo) => ce.EmpleadoCero -= metodoProtocolo;

        public void Salida()
        {

            ce.Salida();

        }

    }
}
