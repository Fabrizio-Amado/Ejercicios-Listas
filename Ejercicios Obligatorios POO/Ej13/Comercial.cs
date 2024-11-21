using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    public class Comercial : Empleado
    {
        double comision;

        public Comercial(string nombre, int edad, int salario, double comision) : base(nombre, edad, salario)
        {
            this.comision = comision;
        }

        public double Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        public void Plus()
        {
            if(Edad > 30 && comision > 300)
            {
                Salario += plus;
            }
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Comisión: {comision}");
        }
    }
}
