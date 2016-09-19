using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_con_Gabriel.Modelo
{
    public class Carro:VehiculoTerrestre
    {
        public override void correr()
        {
            Console.Write("Carro : Corriendo\n");
        }

        public override void transportar()
        {
            Console.Write("Carro : Transportando\n");
        }

        public override void arrancar()
        {
            Console.Write("Carro : Arrancando\n");
        }

        public override void detener()
        {
            Console.Write("Carro : Deteniendose\n");
        }

        public override void frenar()
        {
            Console.Write("Carro : Frenando\n");
        }

        public void estrellarse() {
            
        }
    }
    public class Moto14:VehiculoTerrestre
    {
        public override void correr()
        {
            Console.Write("Moto : Corriendo\n");
        }

        public override void transportar()
        {
            Console.Write("Moto : Transportando\n");
        }

        public override void arrancar()
        {
            Console.Write("Moto : Arrancando\n");
        }

        public override void detener()
        {
            Console.Write("Moto : Deteniendose\n");
        }

        public override void frenar()
        {
            Console.Write("Moto : Frenando\n");
        }
    }

    public class Bicicleta:VehiculoTerrestre
    {
        public override void correr()
        {
            Console.Write("Bicicleta : Corriendo\n");
        }

        public override void transportar()
        {
            Console.Write("Bicicleta : Transportandose\n");
        }

        public override void arrancar()
        {
            Console.Write("Bicicleta : Arrancando\n");
        }

        public override void detener()
        {
            Console.Write("Bicicleta : Deteniendose\n");
        }

        public override void frenar()
        {
            Console.Write("Bicicleta : Frenando\n");
        }
    }
    public class CarroElectrico: Carro
    {
        Carro c = new CarroElectrico(); //polimorfismo

        public override void correr()
        {
            base.correr();
            Console.Write("CarroElectrico : Corriendo\n");
        }

        public override void transportar()
        {
            Console.Write("CarroElectrico : Transportando\n");
        }

        public override void arrancar()
        {
            Console.Write("CarroElectrico : Arrancando\n");
        }

        public override void detener()
        {
            Console.Write("CarroElectrico : Deteniendose\n");
        }

        public override void frenar()
        {
            Console.Write("CarroElectrico : Frenando\n");
        }
    }
}
