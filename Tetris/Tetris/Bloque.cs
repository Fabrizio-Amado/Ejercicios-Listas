using System;
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
