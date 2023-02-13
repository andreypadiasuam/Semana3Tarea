using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Clases;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizar un ciclo "while" para pedir al usuario que ingrese
            //las materias y profesores correspondientes hasta que desee salir.
            //Utilizar una estructura "if-else" para verificar si el profesor ya ha
            //sido ingresado previamente y evitar duplicidades.
            bool opcionMenu = true;
            Dictionary<Materia, Profesor> dicCursos = new Dictionary<Materia, Profesor>();  
            while (opcionMenu)
            {
                Materia materia = new Materia();
                Profesor profesor = new Profesor();
                Console.WriteLine("Bienvenido al sistema");
                Console.WriteLine("Ingrese el nombre del Curso");
                materia._nombreMateria = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del Profesor");
                profesor._nombre = Console.ReadLine();

                Console.WriteLine("Desea agregar mas cursos? Escriba si o no");
                string respuesta = Console.ReadLine();

                if (respuesta == "no")
                {
                    opcionMenu = false;
                }

                foreach (KeyValuePair<Materia, Profesor> item in dicCursos)
                {
                    if (item.Key._nombreMateria.ToLower() == materia._nombreMateria.ToLower()) 
                    {
                        Console.WriteLine("Este curso ya fue agregado, no se puede agregar" +
                            "de nuevo");
                    }
                    else
                    {
                        dicCursos.Add(materia, profesor);
                    }
                }

                
            }

            foreach (KeyValuePair<Materia, Profesor> item in dicCursos)
            {
                Console.WriteLine("Nombre de materia: {0} \n Nombre Profesor: {1}"
                    ,item.Key._nombreMateria, item.Value._nombre);

                Console.ReadKey();
            }

            //Crear Lista de estudiantes
            List<Estudiante> estudiantes = new List<Estudiante>();
            bool menuEstudiantes = true;
            Console.WriteLine("Ingreso de estudiantes");
            while (menuEstudiantes)
            {
                Estudiante estudiante = new Estudiante();
                Console.WriteLine("Ingrese el nombre del Estudiante");
                estudiante._nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del Estudiante");
                estudiante._edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Desea agregar mas estudiantes? Escriba si o no");
                string respuesta = Console.ReadLine();

                if (respuesta == "no")
                {
                    menuEstudiantes = false;
                }
            }


            //Imprimir estudiantes para seleccionarlos
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine("{0} - {1}",
                    estudiantes.IndexOf(estudiante), estudiante._nombre);
            }

            Console.WriteLine("Seleccione un estudiante");
            int indexEstudiante = Convert.ToInt32(Console.ReadLine());
            estudiantes[indexEstudiante].MostrarDatos();



        }
    }
}
