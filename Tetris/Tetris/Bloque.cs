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
