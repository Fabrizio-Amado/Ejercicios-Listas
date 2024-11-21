using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej07
{
    public class Raices
    {
        int a, b, c;
        double discriminante, raiz1, raiz2;
        bool tieneRaices = false;
        bool tieneRaiz = false;

        public Raices(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetDiscriminante()
        {
            discriminante = Math.Pow(b, 2) - (4 * a * c);
            return discriminante;
        }

        public bool TieneRaices()
        {
            if(discriminante > 0)
            {
                tieneRaices = true;
            }
            return tieneRaices;
        }
        public bool TieneRaiz()
        {
            if (discriminante == 0)
            {
                tieneRaiz = true;
            }
            return tieneRaiz;
        }

        public (double? raiz1, double? raiz2) Calcular()
        {
            if (tieneRaices == true)
            {
                raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                return (raiz1, raiz2);
            }
            else if (tieneRaiz == true)
            {
                raiz1 = -b / (2 * a);
                return (raiz1, null);
            }
            else
            {
                Console.WriteLine("No hay solución.");
                return (null, null);
            }
        }

        public void ObtenerRaices()
        {
            if (tieneRaices == true)
            {
                Console.WriteLine($"Las soluciones son: {raiz1} y {raiz2}");
                Console.WriteLine("\n");
            }
        }
        public void ObtenerRaiz()
        {
            if (tieneRaiz == true)
            {
                Console.WriteLine($"La solución es: {raiz1}");
                Console.WriteLine("\n");
            }
        }
    }
}
