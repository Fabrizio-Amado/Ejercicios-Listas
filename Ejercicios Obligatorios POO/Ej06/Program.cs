using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ej06
{
    internal class Program
    {
        static List<Libro> libros = new List<Libro>();
        static Libro libroMayor;
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();
            libro1.SetIsbn(112234);
            libro1.SetTitulo("Guerra y Paz");
            libro1.SetAutor("Lev Tolstoi");
            libro1.SetNumPaginas(1240);

            Libro libro2 = new Libro();
            libro2.SetIsbn(679853);
            libro2.SetTitulo("Harry Potter");
            libro2.SetAutor("J.K.Rowling");
            libro2.SetNumPaginas(360);

            libros.Add(libro1);
            libros.Add(libro2);

            foreach(Libro libro in libros)
            {
                libro.MostrarInfo();
            }

            for (int i = 0; i < libros.Count; i++)
            {
                libroMayor = libros[0];
                if(libroMayor.GetNumPaginas() < libros[i].GetNumPaginas())
                    libroMayor = libros[i];
            }
            Console.Write($"El libro con más páginas es: {libroMayor.GetTitulo()}");

            Console.ReadKey();
        }
    }
}
