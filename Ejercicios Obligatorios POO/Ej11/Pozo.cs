using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    public class Pozo
    {
        List<Jugador> jugadores;
        Partido partido;
        bool final = false;
        int dinero = 0;

        public int Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        public bool Final
        {
            get { return final; }
            set { final = value; }
        }

        public Pozo(List<Jugador> jugadores, Partido partido)
        {
            this.jugadores = jugadores;
            this.partido = partido;
        }

        public void Ronda(Random r)
        {
            string resultado = partido.Resultado(r);
            Console.WriteLine($"{partido.Juego(r)}");
            for (int i = jugadores.Count - 1; i >= 0; i--)
            {
                if (jugadores[i].HabilitadoApostar() == true)
                {
                    jugadores[i].Dinero -= 1;
                    this.dinero += 1;
                }
                else
                {
                    jugadores.RemoveAt(i);
                }
            }
            Console.WriteLine($"Resultados: {resultado}");
            if(jugadores.Count > 0)
            {
                foreach(Jugador jugador in jugadores)
                {
                    string apuesta = jugador.Resultado(r);
                    if(resultado == apuesta)
                    {
                        jugador.Victorias++;
                        Console.WriteLine($"El apostador que ganó fue {jugador.Nombre}");
                        if (jugador.Victorias == 2)
                        {
                            jugador.Dinero += dinero;
                            dinero = 0;
                            Console.WriteLine($"{jugador.Nombre} ganó la apuesta quedándose con ${jugador.Dinero}.");
                            final = true;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{jugador.Nombre} no ganó la apuesta.");
                    }
                }
            }
            else
            {
                Console.WriteLine($"El pozo se acumula.");
                final = true;
            }
        }
    }
}
