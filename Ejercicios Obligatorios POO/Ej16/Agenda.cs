using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    public class Agenda
    {
        List<Contacto> contactos = new List<Contacto>();
        int cantidadContactos = 10;

        public Agenda(List<Contacto> contactos, int cantidadContactos)
        {
            this.contactos = contactos;
            this.cantidadContactos = cantidadContactos;
        }

        public Agenda(List<Contacto> contactos)
        {
            this.contactos = contactos;
        }

        public int CantidadContactos
        {
            get { return cantidadContactos; }
            set { cantidadContactos = value; }
        }

        public void AgregarContacto(Contacto c)
        {
            if (!ExisteContacto(c) && !AgendaLlena())
            {
                contactos.Add(c);
            }
        }

        public bool ExisteContacto(Contacto c)
        {
            for(int i = 0; i < contactos.Count; i++)
            {
                if(contactos[i].Nombre == c.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public void ListarContactos()
        {
            foreach (Contacto c in contactos)
            {
                Console.WriteLine($"Nombre: {c.Nombre}");
                Console.WriteLine($"Teléfono: {c.Telefono}");
            }
        }

        public void BuscaContacto(string nombre)
        {
            foreach (Contacto c in contactos)
            {
                if(c.Nombre == nombre)
                {
                    Console.WriteLine($"El teléfono es: {c.Telefono}");
                }
            }
        }

        public void EliminarContacto(string nombre)
        {
            for (int i = 0; i < contactos.Count; i++)
            {
                if (contactos[i].Nombre == nombre)
                {
                    contactos.RemoveAt(i);
                    Console.WriteLine($"El contacto {nombre} fue eliminado de la agenda.");
                }
            }
        }

        public bool AgendaLlena()
        {
            if(contactos.Count == cantidadContactos)
            {
                return true;
            }
            return false;
        }

        public void HuecosLibres()
        {
            int diferencia = cantidadContactos - contactos.Count;
            if (diferencia >= 0)
            {
                Console.WriteLine($"Hay {diferencia} huecos libres.");
            }
        }
    }
}
