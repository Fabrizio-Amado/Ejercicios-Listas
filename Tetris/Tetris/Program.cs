using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris;

namespace Tetris
{
    internal class Program
    {
        static List<Pieza> piezas = new List<Pieza>();
        static void Main(string[] args)
        {            
            piezas.Add(new Linea(1, 5));
            piezas.Add(new Linea(1, 25));
            /*Pieza p = new Pieza("linea");

            while (true)
            {   
                //checkear teclado
                p.derecha();
            }*/


            foreach (Pieza pieza in piezas)
            {
                pieza.Dibujar();
            }


            Console.ReadKey();
        }
    }
}