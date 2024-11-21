using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Password password1 = new Password();
            password1.SetLongitud(8);
            password1.generarPassword();
            password1.MostrarContra();

            if(password1.esFuerte() == true)
            {
                Console.WriteLine("Su contraseña es fuerte.");
            }
            else
            {
                Console.WriteLine("Su contraseña no es fuerte.");
            }
            Console.ReadKey();
        }
    }
}
