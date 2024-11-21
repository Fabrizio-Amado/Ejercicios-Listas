using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    public class Electrodomestico
    {
        protected float precioBase;
        protected int peso;
        protected string color;
        protected char consumoEnergetico;

        private const string colorDefecto = "blanco";
        private const char consumoDefecto = 'F';
        private const float precioDefecto = 100;
        private const int pesoDefecto = 5;

        public Electrodomestico()
        {
            color = colorDefecto;
            consumoEnergetico = consumoDefecto;
            precioBase = precioDefecto;
            peso = pesoDefecto;
        }

        public Electrodomestico(float precioBase, int peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }

        public Electrodomestico(float precioBase, string color, char consumoEnergetico, int peso)
        {
            this.precioBase = precioBase;
            this.color = ComprobarColor(color);
            this.consumoEnergetico = ComprobarConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }

        public float getPrecioBase()
        {
            return precioBase;
        }

        public string getColor()
        {
            return color;
        }

        public char getConsumoEnergetico()
        {
            return consumoEnergetico;
        }

        public int getPeso()
        {
            return peso;
        }

        private char ComprobarConsumoEnergetico(char consumoEnergetico)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };

            foreach(char c in letras)
            {
                if(consumoEnergetico == c)
                {
                    return c;
                }
            }
            return consumoDefecto;
        }

        private string ComprobarColor(string color)
        {
            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };

            foreach (string col in colores)
            {
                if(color.ToLower() == col)
                {
                    return col;
                }
            }
            return colorDefecto;
        }

        public virtual float PrecioFinal()
        {
            switch (consumoEnergetico)
            {
                case 'A':
                    precioBase += 100;
                    break;
                case 'B':
                    precioBase += 80;
                    break;
                case 'C':
                    precioBase += 60;
                    break;
                case 'D':
                    precioBase += 50;
                    break;
                case 'E':
                    precioBase += 30;
                    break;
                case 'F':
                    precioBase += 10;
                    break;
            }

            if(peso >= 0 && peso <= 19)
            {
                precioBase += 10;
            }
            else if(peso >= 20 && peso <= 49)
            {
                precioBase += 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                precioBase += 80;
            }
            else if(peso >= 80)
            {
                precioBase += 100;
            }
            return precioBase;
        }
    }
}
