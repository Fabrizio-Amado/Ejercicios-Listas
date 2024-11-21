using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    public class Jugador : IApostar
    {
        string nombre;
        int dinero, victorias;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        public int Victorias
        {
            get { return victorias; }
            set { victorias = value; }
        }

        public Jugador(string nombre, int dinero)
        {
            this.nombre = nombre;
            this.dinero = dinero;
        }

        public string Resultado(Random r)
        {
            int resultado1 = r.Next(0, 6);
            int resultado2 = r.Next(0, 6);
            string resultados = $"{resultado1} - {resultado2}";
            return resultados;
        }

        public bool HabilitadoApostar()
        {
            if(dinero > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
