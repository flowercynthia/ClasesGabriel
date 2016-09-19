using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_con_Gabriel.Modelo
{
    public abstract class Vehiculo
    {
        //private string color; = esto es un atributo

        //public string color { get; set; }//propiedades
        private string _color;
        public string color//otra manera d definir propiedades
        {
            get {return _color;}
            //private set { _color = value; }
        }
        public string marca { get; set; }
        public Decimal precio { get; set; }
        public string modelo { get; set; }
        public double velocidad { get; set; }

        public abstract void transportar();

        public abstract void arrancar();

        public abstract void detener();

        public abstract void frenar();
        //private
    }
}
