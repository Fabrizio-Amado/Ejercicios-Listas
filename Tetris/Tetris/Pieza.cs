<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Pieza
    {
        public List<Bloque> bloques = new List<Bloque>();
        public Pieza()
        {

        }

        public void Dibujar()
        {
            foreach (Bloque bloque in bloques)
            {
                Console.SetCursorPosition(bloque.Col, bloque.Row);
                Console.Write("*");
            }
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
    public class Pieza
    {
        public Pieza()
        {

        }


    }
}
>>>>>>> 7dc2ab00139d826f66422fb8bf8ed102d74b858b
