using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    public class AguaMineral : Bebida
    {
        string origen;

        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }
        public AguaMineral(int id, float cantidadLitros, float precio, string marca, string origen) : base(id, cantidadLitros, precio, marca)
        {
            this.origen = origen;
        }
    }
}
