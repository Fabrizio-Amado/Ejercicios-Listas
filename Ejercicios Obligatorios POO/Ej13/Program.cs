using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comercial comercial1 = new Comercial("José", 39, 34, 400.2);
            Comercial comercial2 = new Comercial("Juan", 27, 25, 14.98);
            Repartidor repartidor1 = new Repartidor("Felipe", 40, 54, "zona 1");
            Repartidor repartidor2 = new Repartidor("Álvaro", 22, 76, "zona 3");

            comercial1.Plus();
            comercial2.Plus();
            repartidor1.Plus();
            repartidor2.Plus();

            comercial1.MostrarDetalles();
            comercial2.MostrarDetalles();
            repartidor1.MostrarDetalles();
            repartidor2.MostrarDetalles();

            Console.ReadKey();
        }
    }
}
