using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];

            series[0] = new Serie("Game of Thrones", 8, "Acción", "George R. R. Martin");
            series[0].entregar();
            series[1] = new Serie("The Simpsons", 36, "Comedia", "Matt Groening");
            series[2] = new Serie("The Crown", "Peter Morgan");
            series[3] = new Serie("Alf", 4, "Comedia", "Paul Fusco");
            series[3].entregar();
            series[4] = new Serie("Un Show Más", "J. G. Quintel");

            videojuegos[0] = new Videojuego("Minecraft", 15, "Acción y Aventura", "Mojang");
            videojuegos[0].entregar();
            videojuegos[1] = new Videojuego("Medieval II: Total War", 30, "Estrategia", "The Creative Assembly");
            videojuegos[2] = new Videojuego("Age of Empires II", 25, "Estrategia", "Ensemble Studios");
            videojuegos[2].entregar();
            videojuegos[3] = new Videojuego("Grand Theft Auto V", 22, "Mundo abierto", "Rockstar Games");
            videojuegos[4] = new Videojuego("Simcity 2000", 18, "Construcción de ciudades", "Maxis");
            videojuegos[4].entregar();

            int cantEntregados = 0;
            int horasEstimadas = 0;
            int numTemporadas = 0;
            Videojuego longestgame = new Videojuego();
            Serie longestserie = new Serie();
            foreach (Videojuego v in videojuegos)
            {
                if(v.isEntregado() == true)
                {
                    cantEntregados += 1;
                }
                if(v.GetHorasEstimadas() > horasEstimadas)
                {
                    horasEstimadas = v.GetHorasEstimadas();
                    longestgame = v;
                }
                Console.WriteLine(v.isEntregado());
            }
            Console.WriteLine($"Total de videojuegos entregados: {cantEntregados}");
            Console.Write("\n");

            cantEntregados = 0;

            foreach (Serie s in series)
            {
                if (s.isEntregado() == true)
                {
                    cantEntregados += 1;
                }
                if (s.GetNumeroDeTemporadas() > numTemporadas)
                {
                    numTemporadas = s.GetNumeroDeTemporadas();
                    longestserie = s;
                }
                Console.WriteLine(s.isEntregado());
            }
            Console.WriteLine($"Total de series entregados: {cantEntregados}");
            Console.Write("\n");
            Console.WriteLine($"El videojuego con más horas tiene: {horasEstimadas} horas y es: ");
            longestgame.MostrarDetalles();
            Console.Write("\n");
            Console.WriteLine($"La serie con más temporadas tiene: {numTemporadas} temporadas y es: ");
            longestserie.MostrarDetalles();

            Console.ReadKey();

        }
    }
}
