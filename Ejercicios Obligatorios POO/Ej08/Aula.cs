using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej08
{
    public class Aula
    {
        int id, maxEstudiantes;
        string materia;
        bool estaDisponible = false;
        bool minAlumnos = false;

        public Aula(int id, int maxEstudiantes, string materia)
        {
            this.id = id;
            this.maxEstudiantes = maxEstudiantes;
            this.materia = materia;
        }

        public bool Clases(bool profesorDisponible, int cantidadEstudiantes, string materia)
        {
            if(profesorDisponible == true && materia == this.materia && cantidadEstudiantes >= maxEstudiantes / 2)
            {
                return true;
            }
            return false;
        }
    }
}
