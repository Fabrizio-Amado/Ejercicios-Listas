using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    public class Bebida
    {
        int id;
        float cantidadLitros, precio;
        string marca;

        public Bebida(int id, float cantidadLitros, float precio, string marca)
        {
            this.id = id;
            this.cantidadLitros = cantidadLitros;
            this.precio = precio;
            this.marca = marca;
        }

        public Bebida()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public float CantidadLitros
        {
            get { return cantidadLitros; }
            set { cantidadLitros = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
