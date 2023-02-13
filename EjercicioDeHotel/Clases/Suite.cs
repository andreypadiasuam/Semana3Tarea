using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeHotel.Clases
{
    internal class Suite : Habitacion, IReservable
    {
        public override double CalcularTarifa()
        {
            Console.WriteLine("Ingrese la cantidad de" +
                " dias que se va a reservar la habitacion");
            int diasReservados = Convert.ToInt32(Console.ReadLine());

            return diasReservados * 35200;
        }

        public void ReservarHabitacion()
        {
            this.disponibilidad = false;
            Console.WriteLine("La habitacion ha sido reservada");
        }
    }
}
