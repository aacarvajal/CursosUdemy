﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    interface IRenderizador
    {
        void Renderizar();
        void Dibujar();

        /**
         * 
         * No se pueden incluir constructores
         * no se puede incluir variables
         * No se puede incluir modificadores de acceso (son publicos por defecto)
         * 
         * 
         */
    }
}
