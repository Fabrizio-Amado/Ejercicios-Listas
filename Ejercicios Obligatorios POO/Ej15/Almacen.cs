using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej15
{
    public class Almacen
    {
        Bebida[,] bebidas;

        public Almacen(Bebida[,] bebidas)
        {
            this.bebidas = bebidas;
        }

        public float CalcularPrecioBebidas()
        {
            float precioTotal = 0;
            foreach(Bebida bebida in bebidas)
            {
                if (bebida is BebidaAzucarada bebidaAzucarada && bebidaAzucarada.TienePromocion == true)
                    bebidaAzucarada.Precio -= bebidaAzucarada.Precio / 10;
                precioTotal += bebida.Precio;
            }
            return precioTotal;
        }

        public float CalcularPrecioMarca(string marca)
        {
            float precioTotal = 0;
            for(int i = 0; i < bebidas.GetLength(0); i++)
            {
                for(int j = 0; j < bebidas.GetLength(1); j++)
                {
                    if (bebidas[i, j].Marca == marca)
                    {
                        precioTotal += bebidas[i, j].Precio;
                    }
                }
            }
            return precioTotal;
        }

        public float CalcularPrecioEstanteria(int numEstanteria)
        {
            float precioTotal = 0;
            for (int i = 0; i < bebidas.GetLength(0); i++)
            {
                precioTotal += bebidas[i, numEstanteria].Precio;
            }
            return precioTotal;
        }

        public void AgregarProducto()
        {
            bool agregado = false;
            for (int i = 0; i < bebidas.GetLength(0); i++)
            {
                for (int j = 0; j < bebidas.GetLength(1); j++)
                {
                    if (bebidas[i, j] == null)
                    {
                        bebidas[i, j] = new Bebida();
                        agregado = true;
                        break;
                    }
                }
                if (agregado) break;
            }
        }

        public void EliminarProducto(int id)
        {
            for(int i = 0; i < bebidas.GetLength(0); i++)
            {
                for (int j = 0; j < bebidas.GetLength(1); j++)
                {
                    if (bebidas[i, j] != null && bebidas[i, j].Id == id)
                    {
                        bebidas[i, j] = null;
                        Console.WriteLine($"Producto con ID {id} eliminado.");
                        return;
                    }
                }
            }
        }

        public void MostrarInformacion()
        {
            for (int i = 0; i < bebidas.GetLength(0); i++)
            {
                for (int j = 0; j < bebidas.GetLength(1); j++)
                {
                    if (bebidas[i, j] != null)
                    {
                        Console.WriteLine($"ID: {bebidas[i, j].Id}");
                        Console.WriteLine($"Marca: {bebidas[i, j].Marca}");
                        Console.WriteLine($"Cantidad de litros: {bebidas[i, j].CantidadLitros}");
                        Console.WriteLine($"Precio: {bebidas[i, j].Precio}");
                        Console.WriteLine("\n");
                        if (bebidas[i, j] is AguaMineral aguaMineral)
                        {
                            Console.WriteLine($"Orígen: {aguaMineral.Origen}");
                            Console.WriteLine("\n");
                        }
                        else if (bebidas[i, j] is BebidaAzucarada bebidaAzucarada)
                        {
                            Console.WriteLine($"Porcentaje de azúcar: {bebidaAzucarada.Azucar}");
                            if (bebidaAzucarada.TienePromocion == true)
                                Console.WriteLine("Tiene una promoción del 10%");
                            Console.WriteLine("\n");
                        }
                    }
                }
            }
        }
    }
}
