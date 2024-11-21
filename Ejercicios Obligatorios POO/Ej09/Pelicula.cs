using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej09
{
    public class Pelicula
    {
        string titulo;
        int duracion;
        int edadMinima;
        string director;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public int EdadMinima
        {
            get { return edadMinima; }
            set { edadMinima = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public Pelicula(string titulo, int duracion, int edadMinima, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
        }
    }
}
