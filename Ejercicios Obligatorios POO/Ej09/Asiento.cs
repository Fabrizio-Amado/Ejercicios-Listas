using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej09
{
    public class Asiento
    {
        int fila;
        char columna;
        bool estaOcupado = false;

        public int Fila
        {
            get { return fila; }
            set { fila = value; }
        }
        public char Columna
        {
            get { return columna; }
            set { columna = value; }
        }
        public bool EstaOcupado
        {
            get { return estaOcupado; }
            set { estaOcupado = value; }
        }

        public Asiento(int fila, char columna)
        {
            this.fila = fila;
            this.columna = columna;
        }

        public override string ToString()
        {
            return $"{Fila + 1}{Columna}";
        }
    }
}
