using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    public class Coche
    {
        private Motor Motor { get; set; }
        public void setMotor(Motor motor) {
            this.Motor = motor;        
        }
        public Motor getMotor()
        {
            return this.Motor ;
        }
        private string Marca { get; }
        private string Modelo { get; }
        private double CostosAverias { get; set; }

        public Coche(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public void acumularAveria() {
            Random rnd = new Random();
            double importe = rnd.Next(1, 2000);
            this.CostosAverias += (importe);
        }
        public string mostrarDatos() {
            return  " Marca: " + this.Marca +
                    " Modelo: " + this.Modelo +
                    " Costos de Averias: " + this.CostosAverias +
                    " Litros de Aceite: " + this.getMotor().getLitros(); 

        }
    }

}
