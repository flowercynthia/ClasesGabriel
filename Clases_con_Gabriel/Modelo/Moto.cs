using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_con_Gabriel.Modelo
{
    public sealed class Moto145
    {
        VehiculoTerrestre m = new CarroElectrico();//polimofirmo porque estamos instanciando de la clase
       //base VehiculoTerrestre
        public void metodo() {
            m = new Carro();
            m.correr();

            m = new Bicicleta();
            Carro r = new Carro();
            
            
        }
    }
   // public 
    
}
