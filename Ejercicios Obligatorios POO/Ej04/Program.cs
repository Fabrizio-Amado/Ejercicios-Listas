using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];
            List<object> listaElectros = new List<object>();
            List<object> televisiones = new List<object>();
            List<object> lavadoras = new List<object>();
            float totalElectro = 0;
            float totalTele = 0;
            float totalLava = 0;

            electrodomesticos[0] = new Lavadora(20, 140, "Gris", 'E', 65);
            electrodomesticos[1] = new Television(32, true, 175, "Negro", 'D', 15);
            electrodomesticos[2] = new Lavadora(35, 200, "rojo", 'C', 75);
            electrodomesticos[3] = new Television(15, false, 90, "blanco", 'F', 20);
            electrodomesticos[4] = new Lavadora(40, 265, "verde", 'A', 60);
            electrodomesticos[5] = new Lavadora(17, 80, "AZUL", 'B', 58);
            electrodomesticos[6] = new Television(65, true, 300, "rojo", 'A', 12);
            electrodomesticos[7] = new Electrodomestico(70, "naranja", 'B', 28);
            electrodomesticos[8] = new Television(50, true, 240, "Azul", 'A', 18);
            electrodomesticos[9] = new Electrodomestico(32, "Negro", 'B', 26);

            foreach (Electrodomestico electros in electrodomesticos)
            {
                if(electros is Television)
                {
                    televisiones.Add(electros);
                }
                else if(electros is Lavadora)
                {
                    lavadoras.Add(electros);
                }
                else
                {
                    listaElectros.Add(electros);
                }
            }

            foreach (Electrodomestico electros in listaElectros)
            {
                electros.PrecioFinal();
                totalElectro += electros.getPrecioBase();
            }

            Console.WriteLine("Televisiones:");

            foreach (Television teles in televisiones)
            {
                teles.PrecioFinal();
                totalTele += teles.getPrecioBase();
                Console.WriteLine($"Precio: ${teles.getPrecioBase()}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Lavadoras:");

            foreach (Lavadora lavas in lavadoras)
            {
                lavas.PrecioFinal();
                totalLava += lavas.getPrecioBase();
                Console.WriteLine($"Precio: ${lavas.getPrecioBase()}");
            }
            totalElectro = totalElectro + totalTele + totalLava;
            Console.Write("\n");
            Console.WriteLine($"Precio total: ${totalElectro}");

            Console.ReadKey();
        }
    }
}
