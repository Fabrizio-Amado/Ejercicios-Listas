using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Ej01
{
    internal class Program
    {
        static double ingreso;
        static double retiro;

        static void Main(string[] args)
        {

            Cuenta c1 = new Cuenta("Fabrizio", 3000);
            Cuenta c2 = new Cuenta("Jorge", 1000);

            Console.Write("Ingrese una cantidad: ");
            ingreso = double.Parse(Console.ReadLine());
            c1.Ingresar(ingreso);

            Console.Write("Retire una cantidad: ");
            retiro = double.Parse(Console.ReadLine());
            c1.Retirar(retiro);

            Console.Write("Ingrese una cantidad: ");
            ingreso = double.Parse(Console.ReadLine());
            c2.Ingresar(ingreso);

            Console.Write("Retire una cantidad: ");
            retiro = double.Parse(Console.ReadLine());
            c2.Retirar(retiro);

            c1.MostrarSaldo();
            c2.MostrarSaldo();

            Console.ReadKey();
        }
    }
}
