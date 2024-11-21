using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12
{
    public class Jugador
    {
        int id;
        string nombre;
        bool vivo = true;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public bool Vivo
        {
            get { return vivo; }
            set { vivo = value; }
        }

        public Jugador(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public void Disparar(Revolver r)
        {
            if(r.Disparar())
            {
                vivo = false;
            }
            else
            {
                r.SiguienteBala();
            }
        }
    }
}
