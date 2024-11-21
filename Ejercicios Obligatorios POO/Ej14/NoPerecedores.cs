using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14
{
    public class NoPerecedores : Producto
    {
        string tipo;

        public NoPerecedores(string nombre, int precio, string tipo) : base(nombre, precio)
        {
            this.tipo = tipo;
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public override int Calcular(List<Producto> productos)
        {
            int precio = base.Calcular(productos);
            return precio;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Tipo: {tipo}\n");
        }
    }
}
