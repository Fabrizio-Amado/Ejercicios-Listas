using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14
{
    public class Perecederos : Producto
    {
        int diasCaducar;

        public Perecederos(string nombre, int precio, int diasCaducar) : base(nombre, precio)
        {
            this.diasCaducar = diasCaducar;
        }

        public int DiasCaducar
        {
            get { return diasCaducar; }
            set { diasCaducar = value; }
        }

        public override int Calcular(List<Producto> productos)
        {
            int precio = base.Calcular(productos);
            if(diasCaducar == 1)
            {
                Precio = precio / 4;
            }
            else if(diasCaducar == 2)
            {
                Precio = precio / 3;
            }
            else if (diasCaducar == 3)
            {
                Precio = precio / 2;
            }
            return precio;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Días para caducar: {diasCaducar}\n");
        }
    }
}
