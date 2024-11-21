using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    public class Partido : IApostar
    {
        string[] equipos;

        public string[] Equipos
        {
            get { return equipos; }
            set { equipos = value; }
        }

        public Partido(string[] equipos)
        {
            this.equipos = equipos;
        }

        public string Resultado(Random r)
        {
            int resultado1 = r.Next(0, 6);
            int resultado2 = r.Next(0, 6);
            string resultados = $"{resultado1} - {resultado2}";
            return resultados;
        }

        public string Juego(Random r)
        {
            int equipo1 = r.Next(0, equipos.Count());
            int equipo2 = r.Next(0, equipos.Count());
            string partido = $"{equipo1} juega contra {equipo2}";
            return partido;
        }
    }
}
