using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    public class Repartidor : Empleado
    {
        string zona;

        public Repartidor(string nombre, int edad, int salario, string zona) : base(nombre, edad, salario) 
        {
            this.zona = zona;
        }

        public string Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        public void Plus()
        {
            if (Edad < 25 && zona == "zona 3")
            {
                Salario += plus;
            }
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Zona: {zona}");
        }

    }
}
