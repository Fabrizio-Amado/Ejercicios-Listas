<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 7dc2ab00139d826f66422fb8bf8ed102d74b858b
