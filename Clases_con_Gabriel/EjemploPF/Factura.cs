using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_con_Gabriel.EjemploPF
{
   public class Factura
    {
        public string IdPago { get; set; }
        public string IdFactura { get; set; }
        public decimal MontoPagar { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaCorte { get; set; }
        public string Colector { get; set; }

        public bool IsValid(IFacturaValidator validator) {
            return validator.ValidarFactura(this);
        }
    }
}
