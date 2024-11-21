using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices r1 = new Raices(1, -3, 2);
            r1.GetDiscriminante();
            r1.TieneRaices();
            r1.TieneRaiz();
            r1.Calcular();
            r1.ObtenerRaices();
            r1.ObtenerRaiz();

            Raices r2 = new Raices(1, -2, 1);
            r2.GetDiscriminante();
            r2.TieneRaices();
            r2.TieneRaiz();
            r2.Calcular();
            r2.ObtenerRaices();
            r2.ObtenerRaiz();

            Raices r3 = new Raices(1, 2, 5);
            r3.GetDiscriminante();
            r3.TieneRaices();
            r3.TieneRaiz();
            r3.Calcular();
            r3.ObtenerRaices();
            r3.ObtenerRaiz();

            Console.ReadKey();
        }
    }
}
