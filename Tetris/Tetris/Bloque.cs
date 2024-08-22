<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Bloque
    {
        string tipo = "*";
        int col;
        int row;
        public int Col { get { return col; } set { col = value; } }
        public int Row { get { return row; } set { row = value; } }
        public Bloque(int col, int row)
        {
            this.col = col;
            this.row = row;
        }


        public virtual void derecha()
        {
            /*foreach (var item in bloques)
            {
                item.x++;
            }*/
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
    public class Bloque
    {
        string tipo = "*";
        int x;
        int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public Bloque(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        public virtual void derecha()
        {
            /*foreach (var item in bloques)
            {
                item.x++;
            }*/
        }


    }
}
>>>>>>> 7dc2ab00139d826f66422fb8bf8ed102d74b858b
