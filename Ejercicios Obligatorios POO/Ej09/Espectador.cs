using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej09
{
    public class Espectador
    {
        string nombre;
        int edad;
        float dinero;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public float Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        public Espectador(string nombre, int edad, float dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }
    }
}
