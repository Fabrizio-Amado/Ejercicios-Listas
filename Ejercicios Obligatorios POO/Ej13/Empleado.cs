using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    public class Empleado
    {
        string nombre;
        int edad;
        int salario;
        protected const int plus = 300;

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

        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Empleado(string nombre, int edad, int salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }

        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Salario: {salario}");
        }
    }
}
