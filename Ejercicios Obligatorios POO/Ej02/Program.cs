using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    internal class Program
    {
        static string nombre;
        static int edad;
        static char sexo;
        static double peso;
        static double altura;
        static void Main(string[] args)
        {

            // Ingreso de parámetros persona 1.
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su sexo: ");
            sexo = char.Parse(Console.ReadLine());

            Console.Write("Ingrese su peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese su altura: ");
            altura = double.Parse(Console.ReadLine());

            Persona p1 = new Persona(nombre, edad, sexo, peso, altura);

            // Ingreso de parámetros persona 2.
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su sexo: ");
            sexo = char.Parse(Console.ReadLine());

            Persona p2 = new Persona(nombre, edad, sexo);
            p2.SetPeso(60);
            p2.SetAltura(1.78);

            // Persona 3 tiene los valores por defecto.
            Persona p3 = new Persona();
            p3.SetNombre("José");
            p3.SetEdad(26);
            p3.SetSexo('h');
            p3.SetPeso(80);
            p3.SetAltura(1.68);

            p1.MostrarDatos();
            p2.MostrarDatos();
            p3.MostrarDatos();

            Console.ReadKey();
        }
    }
}
