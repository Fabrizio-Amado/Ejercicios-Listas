using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    public class Television : Electrodomestico
    {
        private int resolucion;
        private bool sintonizadorTDT;

        private const int resolucionDefecto = 20;
        private const bool sintonizadorDefecto = false;

        public Television()
        {
            resolucion = resolucionDefecto;
            sintonizadorTDT = sintonizadorDefecto;
        }

        public Television(int precio, int peso) : base(precio, peso)
        {
            resolucion = resolucionDefecto;
            sintonizadorTDT = sintonizadorDefecto;
        }

        public Television(int res, bool sintonizador, int precio, string color, char consumoEnergetico, int peso) : base(precio, color, consumoEnergetico, peso)
        {
            resolucion = res;
            sintonizadorTDT = sintonizador;
        }

        public int GetResolucion()
        {
            return resolucion;
        }

        public bool GetSintonizador()
        {
            return sintonizadorTDT;
        }

        public override float PrecioFinal()
        {
            base.PrecioFinal();
            if(resolucion > 40 && sintonizadorTDT == true)
            {
                precioBase *= (float)1.3;
                precioBase += 50;
            }
            else if (resolucion > 40)
            {
                precioBase *= (float)1.3;
            }
            else if (sintonizadorTDT == true)
            {
                precioBase += 50;
            }
            return precioBase;
        }
    }
}
