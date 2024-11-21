using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();
            Revolver revolver = new Revolver();
            Juego juego = new Juego(jugadores, revolver);

            Console.Write("Ingrese la cantidad de jugadores, debe ser entre 2 y 6: ");
            int cantidad = int.Parse(Console.ReadLine());

            if(cantidad < 2 || cantidad > 6)
            {
                cantidad = 6;
            }

            for(int i = 1; i <= cantidad; i++)
            {
                jugadores.Add(new Jugador(i, $"Jugador {i}"));
            }

            juego.Comienzo();

            Console.ReadKey();
        }
    }
}
