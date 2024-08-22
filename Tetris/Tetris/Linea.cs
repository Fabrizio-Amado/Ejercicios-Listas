using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Linea : Pieza
    {        
        public Linea(int col, int row) 
        {            
            bloques.Add(new Bloque(col+1, row + 1));
            bloques.Add(new Bloque(col + 2, row + 1));
            bloques.Add(new Bloque(col + 3, row + 1));
            bloques.Add(new Bloque(col + 4, row + 1));
        }
    }
}
