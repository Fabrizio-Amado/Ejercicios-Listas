using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    public class Serie
    {
        string titulo = "";
        int numeroDeTemporadas = 3;
        bool entregado = false;
        string genero = "";
        string creador = "";

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetNumeroDeTemporadas(int numero)
        {
            this.numeroDeTemporadas = numero;
        }

        public int GetNumeroDeTemporadas()
        {
            return numeroDeTemporadas;
        }

        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        public string GetGenero()
        {
            return genero;
        }

        public void SetCreador(string creador)
        {
            this.creador = creador;
        }

        public string GetCreador()
        {
            return creador;
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
            return this.numeroDeTemporadas.CompareTo(a);
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"{titulo} del género {genero} y fue creado por {creador}");
        }

        public Serie()
        {

        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, int numero, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroDeTemporadas = numero;
            this.genero = genero;
            this.creador = creador;
        }
    }
}
