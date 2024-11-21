using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public class Persona
    {
        string nombre = "";
        int edad = 0;
        string dni;
        char sexo = 'h';
        double peso = 0;
        double altura = 0;
        static Random r = new Random();

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Persona()
        {
            generaDNI();
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            generaDNI();
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Peso = peso;
            this.Altura = altura;
            generaDNI();
        }

        public int CalcularIMC()
        {
            int valor = 0;
            double imc;

            imc = Peso / (Altura * Altura);

            if (imc < 20)
            {
                valor = -1;
            }

            else if (imc >= 20 && imc <= 25)
            {
                valor = 0;
            }

            else if (imc > 25)
            {
                valor = 1;
            }
            return valor;
        }


        public bool esMayorDeEdad()
        {
            bool bandera = false;

            if (Edad >= 18)
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }
            return bandera;
        }

        public void generaDNI()
        {
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            int dNi = r.Next(00000000, 99999999);
            dNi = r.Next(00000000, 99999999);
            for (int i = 0; i <= 23; i++)
            {
                if (dNi % 23 == i)
                {
                    Dni = dNi.ToString();
                    Dni += letras[i];
                }
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Su nombre es: {Nombre}");
            Console.WriteLine($"Su edad es: {Edad}");
            Console.WriteLine($"Su sexo es: {Sexo}");
            Console.WriteLine($"Su peso es: {Peso}");
            Console.WriteLine($"Su altura es: {Altura}");
            Console.WriteLine($"Su dni es: {Dni}");

            if (CalcularIMC() == -1)
            {
                Console.WriteLine("Usted tiene un peso menor a la media.");
            }
            else if (CalcularIMC() == 0)
            {
                Console.WriteLine("Usted está en su peso ideal.");
            }
            else if (CalcularIMC() == 1)
            {
                Console.WriteLine("Usted tiene sobrepeso.");
            }

            if (esMayorDeEdad() == true)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad.");
            }
            Console.Write("\n");
        }

        public void SetNombre(string Nombre)
        {
            nombre = Nombre;
        }
        public void SetEdad(int Edad)
        {
            edad = Edad;
        }
        public void SetSexo(char Sexo)
        {
            sexo = Sexo;
        }
        public void SetPeso(double Peso)
        {
            peso = Peso;
        }
        public void SetAltura(double Altura)
        {
            altura = Altura;
        }
    }
}
