using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_con_Gabriel.EjemploPF
{
    public class Result{
        public bool Status { get; set; }
        public string message { get; set; }
    }
    public class PagoFactura
    {
        public Result Pagar(Factura factura)
        {
            //var  = new Factura() {
            //    MontoTotal = 500,
            //    MontoPagar = 400,
            //    FechaCorte = DateTime.Now.AddDays(3),
            //    FechaPago = DateTime.Now,
            //    IdFactura = "123",
            //    IdPago = "354",
            //    Colector = "Ficohsa"
            //};
            
            bool isvalid = false;

            if (factura.Colector.Equals("Ficohsa"))
            {
                isvalid = factura.IsValid(new FicohsaFacturaValidator());
                   
            }
            if (factura.Colector.Equals("Movistar"))
            {
                isvalid = factura.IsValid(new MovistarFacturaValidator());

            }

            if (isvalid)
                return new Result() { Status = true, message = "Factura pagada" };
            else
                return new Result() { Status = false, message = "Datos invalidos" };
        }
    }
}
