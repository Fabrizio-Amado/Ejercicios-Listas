using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12
{
    public class Revolver
    {
        int posicionActual, posicionBala;

        public int PosicionActual
        {
            get { return posicionActual; }
            set { posicionActual = value; }
        }

        public int PosicionBala
        {
            get { return posicionBala; }
            set { posicionBala = value; }
        }

        public bool Disparar()
        {
            if (posicionBala == posicionActual)
            {
                return true;
            }
            return false;
        }

        public void SiguienteBala()
        {
            posicionActual++;
        }
    }
}
