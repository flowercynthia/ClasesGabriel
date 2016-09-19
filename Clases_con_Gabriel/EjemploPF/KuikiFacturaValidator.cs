using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_con_Gabriel.EjemploPF
{
   public class KuikiFacturaValidator : IFacturaValidator
    {

        public bool ValidarFactura(Factura factura)
        {
            return factura.FechaPago > factura.FechaCorte ? factura.MontoPagar == factura.MontoTotal : true ;
        }
    }
}
