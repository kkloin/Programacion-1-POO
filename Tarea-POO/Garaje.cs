using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    public class Garaje
    {
        private Coche Coche { get; set; }
        private string Averia { get; set; }
        public int CochesAtendidos { get; set; }
        private bool Ocupado { get; set; }

        public bool aceptarCoche(Coche coche, string averia) { 
            if (this.Ocupado) {
                return false; 
            }
            if (averia.ToLower() == "aceite") {
                int aceiteActual = coche.getMotor().getLitros();
                coche.getMotor().setLitros(aceiteActual + 10);
            }
            this.Coche = coche;
            return true;
        }
        public void devolverCoche() {
            this.Ocupado = false;
            this.Coche.acumularAveria();
        }
    }
}
