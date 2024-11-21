using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej08
{
    public class Estudiante
    {
        string nombre;
        int edad;
        char sexo;
        int calificacion;
        bool faltar = false;

        public Estudiante(string nombre, int edad, char sexo, int calificacion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.calificacion = calificacion;
        }
        public bool GetFaltarEstudiante()
        {
            return faltar;
        }
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };
        public bool Falta()
        {
            Random random = new Random();
            int falta = random.Next(1, 11);

            if (falta >= 5)
            {
                faltar = true;
            }
            return faltar;
        }
    }
}
