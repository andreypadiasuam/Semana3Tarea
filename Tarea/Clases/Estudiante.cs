using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Clases
{
    public class Estudiante : Persona
    {
        public override void MostrarDatos()
        {
            Console.WriteLine("Los datos del estudiante son: \n Nombre: {0} \n Edad: {1}", _nombre,_edad);
            
        }
    }
}
