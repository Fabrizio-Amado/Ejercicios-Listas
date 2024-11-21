using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej10
{
    public class Baraja
    {
        int cantCartas = 40;
        List<Carta> cartas = new List<Carta>();
        List<Carta> cartasSalido = new List<Carta>();
        Random random = new Random();

        public void RecibirCartas()
        {
            cartas.Add(new Carta(1, "espadas"));
            cartas.Add(new Carta(2, "espadas"));
            cartas.Add(new Carta(3, "espadas"));
            cartas.Add(new Carta(4, "espadas"));
            cartas.Add(new Carta(5, "espadas"));
            cartas.Add(new Carta(6, "espadas"));
            cartas.Add(new Carta(7, "espadas"));
            cartas.Add(new Carta(10, "espadas"));
            cartas.Add(new Carta(11, "espadas"));
            cartas.Add(new Carta(12, "espadas"));

            cartas.Add(new Carta(1, "basto"));
            cartas.Add(new Carta(2, "basto"));
            cartas.Add(new Carta(3, "basto"));
            cartas.Add(new Carta(4, "basto"));
            cartas.Add(new Carta(5, "basto"));
            cartas.Add(new Carta(6, "basto"));
            cartas.Add(new Carta(7, "basto"));
            cartas.Add(new Carta(10, "basto"));
            cartas.Add(new Carta(11, "basto"));
            cartas.Add(new Carta(12, "basto"));

            cartas.Add(new Carta(1, "oro"));
            cartas.Add(new Carta(2, "oro"));
            cartas.Add(new Carta(3, "oro"));
            cartas.Add(new Carta(4, "oro"));
            cartas.Add(new Carta(5, "oro"));
            cartas.Add(new Carta(6, "oro"));
            cartas.Add(new Carta(7, "oro"));
            cartas.Add(new Carta(10, "oro"));
            cartas.Add(new Carta(11, "oro"));
            cartas.Add(new Carta(12, "oro"));

            cartas.Add(new Carta(1, "copa"));
            cartas.Add(new Carta(2, "copa"));
            cartas.Add(new Carta(3, "copa"));
            cartas.Add(new Carta(4, "copa"));
            cartas.Add(new Carta(5, "copa"));
            cartas.Add(new Carta(6, "copa"));
            cartas.Add(new Carta(7, "copa"));
            cartas.Add(new Carta(10, "copa"));
            cartas.Add(new Carta(11, "copa"));
            cartas.Add(new Carta(12, "copa"));

        }
        public void MostrarBaraja()
        {
            Console.WriteLine("Cartas en el mazo:\n");
            foreach (Carta carta in cartas)
            {
                Console.WriteLine($"Número: {carta.Numero} Palo: {carta.Palo}");
            }
        }

        public void Barajar()
        {
            int n = cartas.Count;
            while (n > 1)
            {
                n--;
                int rand = random.Next(n + 1);
                Carta temp = cartas[rand];
                cartas[rand] = cartas[n];
                cartas[n] = temp;
            }
        }


        public void SiguienteCarta()
        {
            bool pedirCarta = false;
            Console.Write("Si quiere sacar una carta escriba S sino presione cualquier tecla: ");
            string respuesta = Console.ReadLine();
            if (respuesta.ToUpper() == "S")
            {
                pedirCarta = true;
            }

            while (pedirCarta)
            {
                if(cartas.Count > 0)
                {
                    Carta carta = cartas[0];
                    cartasSalido.Add(carta);
                    Console.WriteLine($"Número: {carta.Numero} Palo: {carta.Palo}");
                    cartas.RemoveAt(0);
                    Console.Write("Si desea continuar escriba S sino presione cualquier tecla: ");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() != "S")
                    {
                        pedirCarta = false;
                    }
                }
                else
                {
                    Console.WriteLine("No hay más cartas en la baraja.");
                    pedirCarta = false;
                }
            }
            Console.Write("\n");
        }

        public void CartasDisponibles()
        {
            Console.WriteLine($"Quedan: {cartas.Count} cartas.");
            Console.Write("\n");
        }

        public void DarCartas()
        {
            Console.Write("¿Cuántas cartas quiere? ");
            int cantidad = int.Parse(Console.ReadLine());

            while(cantidad > 0)
            {
                if(cantidad <= cartas.Count)
                {
                    Carta carta = cartas[0];
                    cartasSalido.Add(carta);
                    Console.WriteLine($"Número: {carta.Numero} Palo: {carta.Palo}");
                    cartas.RemoveAt(0);
                    cantidad--;
                }
                else
                {
                    Console.WriteLine("No hay suficientes cartas.");
                    break;
                }
            }
            Console.Write("\n");
        }

        public void CartasMonton()
        {
            if (cartasSalido.Count > 0)
            {
                Console.WriteLine("Cartas que han salido:\n");
                foreach(Carta carta in cartasSalido)
                {
                    Console.WriteLine($"Número: {carta.Numero} Palo: {carta.Palo}");
                }
            }
            else
            {
                Console.WriteLine("No han salido cartas.");
            }
            Console.Write("\n");
        }
    }
}
