using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    public class Motor
    {
        private int LitrosDeAceite { get; set; } = 0;
        public int getLitros()
        {
            return this.LitrosDeAceite;
        }
        public void setLitros(int litros)
        {
            this.LitrosDeAceite = litros;
        }
        private int Potencia { get; set; }

        public Motor(int potencia)
        {
            this.Potencia = potencia;   
        }
    }
}
