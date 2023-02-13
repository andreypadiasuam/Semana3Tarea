using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Clases
{
    public abstract class Persona
    {
        //Atributos
        string Nombre { get; set; }
        int Edad { get; set; }

        //Metodos
        public abstract void MostrarDatos();

        public string _nombre { get => Nombre; set => Nombre = value; }
        public int _edad { get => Edad; set => Edad = value; }

    }
}
