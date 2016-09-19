using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_con_Gabriel.Modelo
{
    public abstract class VehiculoAereo:Vehiculo
    {
        public abstract void volar();
        public abstract void despegar();
        public abstract void aterrizar();

    }
}
