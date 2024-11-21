using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja = new Baraja();

            baraja.RecibirCartas();
            baraja.Barajar();
            baraja.DarCartas();
            baraja.SiguienteCarta();
            baraja.CartasDisponibles();
            baraja.CartasMonton();
            baraja.MostrarBaraja();

            Console.ReadKey();
        }
    }
}
