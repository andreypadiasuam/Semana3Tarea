using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Clases
{
    public class Materia
    {
         string nombreMateria { get; set; }
        public string _nombreMateria { get => nombreMateria; set => nombreMateria = value; }

        public void Calificar(Estudiante estudiante, int Nota) 
        {
            
            if (Nota>=70)
            {
                Console.WriteLine("{0} ha aprobado el curso.", estudiante._nombre);
            }
        }
    
    }
}
