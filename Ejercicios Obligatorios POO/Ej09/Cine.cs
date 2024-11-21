using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ej09
{
    public class Cine
    {
        Asiento[,] asientos;
        Pelicula pelicula;
        float precio;

        public Cine(Pelicula pelicula, float precio)
        {
            this.pelicula = pelicula;
            this.precio = precio;

            asientos = new Asiento[8, 9];
            char columna = 'A';

            for (int f = 0; f <= 7; f++)
            {
                for (int c = 0; c <= 8; c++)
                {
                    asientos[f, c] = new Asiento(f, columna);
                    columna++;
                }
                columna = 'A';
            }
        }

        public void SentarEspectador(Espectador espectador)
        {
            if (espectador.Dinero >= precio && espectador.Edad >= pelicula.EdadMinima)
            {
                for (int f = 7; f >= 0; f--)
                {
                    for (int c = 8; c >= 0; c--)
                    {
                        if (!asientos[f, c].EstaOcupado)
                        {
                            asientos[f, c].EstaOcupado = true;
                            espectador.Dinero -= precio;
                            Console.WriteLine($"El espectador {espectador.Nombre} se va a sentar en el asiento {asientos[f, c]}");
                            return;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"El espectador {espectador.Nombre} no cumple con los requisitos para entrar.");
            }
        }

    }
}
