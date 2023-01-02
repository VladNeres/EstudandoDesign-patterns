﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.parte3
{
    public class EstadoContrato
    {
        public Contrato Contrato { get; private set; }

            public EstadoContrato(Contrato contrato)
            {
                Contrato = contrato;
            }
    }
}
