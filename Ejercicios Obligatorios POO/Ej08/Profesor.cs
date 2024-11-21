using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej08
{
    public class Profesor
    {
        string nombre;
        int edad;
        char sexo;
        string materia;
        bool faltar = false;

        public Profesor(string nombre, int edad, char sexo, string materia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.materia = materia;
        }

        public string GetMateria()
        {
            return materia;
        }

        public bool Falta()
        {
            Random random = new Random();
            int falta = random.Next(1, 11);
            
            if(falta >= 2)
            {
                faltar = true;
            }
            return faltar;
        }

    }
}
