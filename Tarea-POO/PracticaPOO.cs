using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    public class PracticaPOO
    {
        public void iniciarGaraje()
        {
            Garaje garaje = new Garaje();

            Coche coche1 = new Coche ("Honda", "Civic");
            Motor motor1 = new Motor(240);
                coche1.setMotor(motor1);

            Coche coche2 = new Coche("Toyota", "Corolla");
            Motor motor2 = new Motor(200);
                coche2.setMotor(motor2);

            garaje.aceptarCoche(coche1, "Aceite");
            garaje.devolverCoche();
            garaje.aceptarCoche(coche2, "Aire");
            garaje.devolverCoche();

            Console.WriteLine(coche1.mostrarDatos());
            Console.WriteLine(coche2.mostrarDatos());
        }
    }
}
