﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_con_Gabriel.EjemploPF
{
    public class FicohsaFacturaValidator : IFacturaValidator
    {
        public bool ValidarFactura(Factura factura)
        {
            return factura.MontoPagar == factura.MontoTotal;
        }
    }
}
