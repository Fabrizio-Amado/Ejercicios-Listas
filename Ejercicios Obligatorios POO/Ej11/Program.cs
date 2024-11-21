using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Jugador> jugadores = new List<Jugador>();

            string[] nombres = {
            "Alejandro", "Carlos", "Diego", "Juan", "Luis",
            "Francisco", "Miguel", "Pedro", "Javier", "Antonio",
            "María", "Ana", "Laura", "Carmen", "Isabella",
            "Sofía", "Lucía", "Paula", "Gabriela", "Marta"
        };


            for (int i = 1; i <= 5; i++)
            {
                jugadores.Add(new Jugador(nombres[rand.Next(nombres.Length)], rand.Next(500, 1001)));
            }

            string[] equipos = {
            "Manchester United",
            "Liverpool",
            "Arsenal",
            "Chelsea",
            "Tottenham Hotspur",
            "Manchester City",
            "Leeds United",
            "West Ham United",
            "Everton"
            };
            Partido partido = new Partido(equipos);

            Pozo pozo = new Pozo(jugadores, partido);

            Task t = Task.Run(async delegate
            {
                while (pozo.Final == false)
                {
                    pozo.Ronda(rand);
                    await Task.Delay(1000);
                }
            });
            t.Wait();

            Console.ReadKey();
        }
    }
}
