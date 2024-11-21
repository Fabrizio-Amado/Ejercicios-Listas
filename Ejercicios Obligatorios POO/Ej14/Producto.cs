using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14
{
    public class Producto
    {
        string nombre;
        int precio;

        public Producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public virtual int Calcular(List<Producto> productos)
        {
            int precio = this.precio * productos.Count;
            return precio;
        }

        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Precio: {precio}");
        }
    }
}
