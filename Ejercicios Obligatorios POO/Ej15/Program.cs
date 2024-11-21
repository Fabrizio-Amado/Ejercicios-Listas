using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebida[,] bebidas = new Bebida[3, 3];

            Bebida bebida1 = new Bebida(2, 2.0f, 15.5f, "Marca Premium");
            AguaMineral agua1 = new AguaMineral(3, 1.0f, 12.0f, "VillaVicencio", "Mendoza");
            AguaMineral agua2 = new AguaMineral(4, 0.75f, 20.0f, "Glaciar", "Manantial");
            BebidaAzucarada azucarada1 = new BebidaAzucarada(5, 1.5f, 8.5f, "Coca-Cola", 10, true);
            BebidaAzucarada azucarada2 = new BebidaAzucarada(6, 2.0f, 9.0f, "Pepsi", 8, false);
            BebidaAzucarada azucarada3 = new BebidaAzucarada(7, 2.5f, 11.0f, "Fanta", 12, true);
            BebidaAzucarada azucarada4 = new BebidaAzucarada(8, 1.25f, 7.5f, "Sprite", 5, false);
            BebidaAzucarada azucarada5 = new BebidaAzucarada(9, 1.75f, 10.5f, "Coca-Cola", 12, true);
            BebidaAzucarada azucarada6 = new BebidaAzucarada(10, 1.5f, 8.0f, "Pepsi", 9, true);

            bebidas[0, 0] = bebida1;
            bebidas[0, 1] = agua1;
            bebidas[0, 2] = agua2;
            bebidas[1, 0] = azucarada1;
            bebidas[1, 1] = azucarada2;
            bebidas[1, 2] = azucarada3;
            bebidas[2, 0] = azucarada4;
            bebidas[2, 1] = azucarada5;
            bebidas[2, 2] = azucarada6;

            Almacen almacen = new Almacen(bebidas);

            Console.WriteLine($"EL precio total de todas las bebidas es: {almacen.CalcularPrecioBebidas()}");

            Console.Write("Ingrese el número de estantería: ");
            int numEstanteria = int.Parse(Console.ReadLine());
            Console.WriteLine($"El precio total de la estantería {numEstanteria} es: {almacen.CalcularPrecioEstanteria(numEstanteria)}");

            Console.Write("Ingrese la marca de la bebida: ");
            string marca = Console.ReadLine();
            Console.WriteLine($"El precio total de la marca {marca} es: {almacen.CalcularPrecioMarca(marca)}");

            almacen.AgregarProducto();

            Console.Write("Ingrese el identificador de la bebida que quiere eliminar: ");
            int id = int.Parse(Console.ReadLine());
            almacen.EliminarProducto(id);
            almacen.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
