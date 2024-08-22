using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Linea : Pieza
    {
        List<Bloque> bloques = new List<Bloque>();
        public Linea(int x, int y) 
        {            
            bloques.Add(new Bloque(x+1, y+1));
            bloques.Add(new Bloque(x+2, y + 1));
            bloques.Add(new Bloque(x+3, y+1));
            bloques.Add(new Bloque(x+4, y+1));
        }
    }
}
