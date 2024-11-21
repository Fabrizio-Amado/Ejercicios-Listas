using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ej12
{
    public class Juego
    {
        List<Jugador> jugadores;
        Revolver revolver;

        public Juego(List<Jugador> jugadores, Revolver revolver)
        {
            this.jugadores = jugadores;
            this.revolver = revolver;
        }

        public void Comienzo()
        {
            Console.WriteLine("¡Comienza la ruleta rusa!");
            Random random = new Random();
            int posicion = random.Next(1, 7);
            revolver.PosicionBala = posicion;

            while (!FinJuego())
            {
                Ronda();
            }

            Console.WriteLine("¡FIN!");
        }

        public bool FinJuego()
        {
            foreach (Jugador jugador in jugadores)
            {
                if (!jugador.Vivo)
                {
                    return true;
                }
            }
            return false;
        }

        public void Ronda()
        {
            foreach (Jugador jugador in jugadores)
            {
                if (jugador.Vivo)
                {
                    Console.WriteLine($"{jugador.Nombre} se apunta con el revolver...");
                    Thread.Sleep(500);
                    jugador.Disparar(revolver);

                    if (!jugador.Vivo)
                    {
                        Console.WriteLine($"{jugador.Nombre} ha muerto.");
                        Thread.Sleep(500);
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{jugador.Nombre} sigue vivo.");
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
