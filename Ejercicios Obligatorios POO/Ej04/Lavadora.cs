using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    public class Lavadora : Electrodomestico
    {
        private int carga;
        private const int cargaDefecto = 5;

        public Lavadora()
        {
            carga = cargaDefecto;
        }

        public Lavadora(float precio, int peso) : base(precio, peso)
        {
            carga = cargaDefecto;
        }

        public Lavadora(int carga, float precio, string color, char consumoEnergetico, int peso) : base(precio, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public int getCarga()
        {
            return carga;
        }

        public override float PrecioFinal()
        {
            base.PrecioFinal();
            if(carga > 30)
            {
                precioBase += 50;
            }
            return precioBase;
        }
    }
}
