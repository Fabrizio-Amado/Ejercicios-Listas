using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    public class Videojuego : IEntregable
    {
        string titulo = "";
        int horasEstimadas = 10;
        bool entregado = false;
        string genero = "";
        string compania = "";

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetHorasEstimadas(int horas)
        {
            this.horasEstimadas = horas;
        }

        public int GetHorasEstimadas()
        {
            return horasEstimadas;
        }

        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        public string GetGenero()
        {
            return genero;
        }

        public void SetCreador(string compania)
        {
            this.compania = compania;
        }

        public string GetCreador()
        {
            return compania;
        }

        public void entregar()
        {
            this.entregado = true;
        }

        public void devolver()
        {
            this.entregado = false;
        }

        public bool isEntregado()
        {
            return this.entregado;
        }

        public int CompareTo(int a)
        {
            return this.horasEstimadas.CompareTo(a);
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"{titulo} del género {genero} y fue desarrollado por {compania}");
        }

        public Videojuego()
        {

        }

        public Videojuego(string titulo, int horas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horas;
        }

        public Videojuego(string titulo, int horas, string genero, string compania)
        {
            this.titulo = titulo;
            this.horasEstimadas = horas;
            this.genero = genero;
            this.compania = compania;
        }
    }
}
