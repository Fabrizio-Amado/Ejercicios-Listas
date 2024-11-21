using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    public class Menu
    {
        public string[] Items { get; }
        public string NombreMenu { get; }
        public int PosMenu { get; }

        public Menu(int posMenu, string nombreMenu, string[] opciones)
        {
            Items = opciones;
            NombreMenu = nombreMenu;
            PosMenu = posMenu;
        }
    }
}
