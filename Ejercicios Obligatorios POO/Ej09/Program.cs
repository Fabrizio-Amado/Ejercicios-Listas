using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelicula pelicula = new Pelicula("Star Wars: Una Nueva Esperanza", 2, 7, "George Lucas");
            Espectador espectador1 = new Espectador("Jorge", 40, 300);
            Espectador espectador2 = new Espectador("Pedro", 16, 200);
            Espectador espectador3 = new Espectador("Juan", 6, 300);
            Espectador espectador4 = new Espectador("Eduardo", 56, 700);
            Espectador espectador5 = new Espectador("Carlos", 16, 1257);
            Espectador espectador6 = new Espectador("Felipe", 20, 12000);
            Espectador espectador7 = new Espectador("Fabrizio", 17, 1000);
            Cine cine = new Cine(pelicula, 170);

            cine.SentarEspectador(espectador1);
            cine.SentarEspectador(espectador2);
            cine.SentarEspectador(espectador3);
            cine.SentarEspectador(espectador4);
            cine.SentarEspectador(espectador5);
            cine.SentarEspectador(espectador6);
            cine.SentarEspectador(espectador7);

            Console.ReadKey();
        }
    }
}
