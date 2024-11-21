using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    public class Password
    {
        private int longitud = 0;
        private string contrasena = "";

        public string GetContrasena()
        {
            return contrasena;
        }

        public int GetLongitud()
        {
            return longitud;
        }

        public void SetLongitud(int longitud)
        {
            this.longitud = longitud;
        }

        public Password()
        {

        }

        public Password(int longitud)
        {
            this.longitud = longitud;
        }

        public bool esFuerte()
        {
            int contadorMayusculas = 0;
            int contadorMinusculas = 0;
            int contadorNumeros = 0;

            foreach (char c in contrasena)
            {
                if (char.IsUpper(c))
                {
                    contadorMayusculas++;
                }
                else if (char.IsLower(c))
                {
                    contadorMinusculas++;
                }
                else if (char.IsDigit(c))
                {
                    contadorNumeros++;
                }
            }

            if (contadorMayusculas > 2 && contadorMinusculas > 1 && contadorNumeros > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string generarPassword()
        {
            Random r = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int tipoCaracter = r.Next(1, 4);
                switch (tipoCaracter)
                {
                    case 1:
                        int numeros = r.Next(0, 10);
                        contrasena += numeros;
                        break;
                    case 2:
                        int minusculas = r.Next(97, 123);
                        contrasena += (char)minusculas;
                        break;
                    case 3:
                        int mayusculas = r.Next(65, 91);
                        contrasena += (char)mayusculas;
                        break;
                }
            }
            return contrasena;
        }

        public void MostrarContra()
        {
            Console.WriteLine($"Su contraseña es: {contrasena}");
        }
    }
}
