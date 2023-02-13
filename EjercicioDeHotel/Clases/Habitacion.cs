using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeHotel.Clases
{
    public abstract class Habitacion
    {
        //Atributos
        public int numeroHabitacion { get; set; }
        public int numeroCamas { get; set; }

        public string tamanoHabitacion { get; set; } //Grande-Pequena

        public bool disponibilidad { get; set; }

        //Metodo abstracto
        public abstract double CalcularTarifa();
    }
}
