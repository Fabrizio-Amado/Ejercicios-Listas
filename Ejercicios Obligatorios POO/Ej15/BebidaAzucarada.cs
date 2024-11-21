using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    public class BebidaAzucarada : Bebida
    {
        int azucar;
        bool tienePromocion = false;

        public BebidaAzucarada(int id, float cantidadLitros, float precio, string marca, int azucar, bool tienePromocion) : base(id, cantidadLitros, precio, marca)
        {
            this.azucar = azucar;
            this.tienePromocion = tienePromocion;
        }

        public int Azucar
        {
            get { return azucar; }
            set { azucar = value; }
        }

        public bool TienePromocion
        {
            get { return tienePromocion; }
            set { tienePromocion = value; }
        }
    }
}
