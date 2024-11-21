using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();

            Perecederos producto1 = new Perecederos("Queso", 200, 50);
            Perecederos producto2 = new Perecederos("Leche", 100, 3);
            Perecederos producto3 = new Perecederos("Yogur", 80, 2);
            Perecederos producto4 = new Perecederos("Carne", 300, 3);
            Perecederos producto5 = new Perecederos("Pescado", 250, 1);
            Perecederos producto6 = new Perecederos("Frutas", 150, 1);

            NoPerecedores producto7 = new NoPerecedores("Pasta", 140, "Cereales y granos");
            NoPerecedores producto8 = new NoPerecedores("Arroz", 120, "Cereales y granos");
            NoPerecedores producto9 = new NoPerecedores("Lentejas", 110, "Legumbres");
            NoPerecedores producto10 = new NoPerecedores("Café", 400, "Bebidas");
            NoPerecedores producto11 = new NoPerecedores("Azúcar", 90, "Dulces");
            NoPerecedores producto12 = new NoPerecedores("Aceite", 200, "Aceites y grasas");

            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);
            productos.Add(producto4);
            productos.Add(producto5);
            productos.Add(producto6);

            productos.Add(producto7);
            productos.Add(producto8);
            productos.Add(producto9);
            productos.Add(producto10);
            productos.Add(producto11);
            productos.Add(producto12);


            foreach (Producto p in productos)
            {
                p.Calcular(productos);
                p.MostrarDetalles();
            }
            Console.ReadKey();
        }
    }
}
