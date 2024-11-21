using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            Profesor profesor = new Profesor("Juan", 47, 'm', "física");
            Estudiante estudiante1 = new Estudiante("Jorge", 16, 'm', 8);
            Estudiante estudiante2 = new Estudiante("María", 16, 'f', 5);
            Estudiante estudiante3 = new Estudiante("Josefina", 15, 'f', 10);
            Estudiante estudiante4 = new Estudiante("Carlos", 15, 'm', 6);
            Estudiante estudiante5 = new Estudiante("Miguel", 16, 'm', 10);
            Estudiante estudiante6 = new Estudiante("Enrique", 15, 'f', 1);
            Estudiante estudiante7 = new Estudiante("Antonella", 15, 'f', 2);
            Estudiante estudiante8 = new Estudiante("Darío", 15, 'm', 4);
            Estudiante estudiante9 = new Estudiante("Pedro", 15, 'm', 9);
            Estudiante estudiante10 = new Estudiante("Constanza", 17, 'f', 6);

            estudiante1.Falta();
            estudiante2.Falta();
            estudiante3.Falta();
            estudiante4.Falta();
            estudiante5.Falta();
            estudiante6.Falta();
            estudiante7.Falta();
            estudiante8.Falta();
            estudiante9.Falta();
            estudiante10.Falta();

            estudiantes.Add(estudiante1);
            estudiantes.Add(estudiante2);
            estudiantes.Add(estudiante3);
            estudiantes.Add(estudiante4);
            estudiantes.Add(estudiante5);
            estudiantes.Add(estudiante6);
            estudiantes.Add(estudiante7);
            estudiantes.Add(estudiante8);
            estudiantes.Add(estudiante9);
            estudiantes.Add(estudiante10);

            List<Estudiante> presentes = new List<Estudiante>();
            Aula aula = new Aula(1, 10, "física");

            foreach (Estudiante e in estudiantes)
            {
                if (e.Falta() == true)
                {
                    presentes.Add(e);
                }
            }

            if (aula.Clases(profesor.Falta(), presentes.Count(), profesor.GetMateria()) == true)
            {
                Console.WriteLine("Clases con normalidad.");
            }
            else
            {
                Console.WriteLine("No hay clases.");
            }

            Console.ReadKey();
        }
    }
}
