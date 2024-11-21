using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej06
{
    public class Libro
    {
        private string titulo, autor;
        int paginas, isbn;

        public void SetIsbn(int ISBN)
        {
            isbn = ISBN;
        }

        public int GetIsbn()
        {
            return isbn;
        }

        public void SetTitulo(string Titulo)
        {
            titulo = Titulo;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetAutor(string Autor)
        {
            autor = Autor;
        }

        public string GetAutor()
        {
            return autor;
        }

        public void SetNumPaginas(int numPag)
        {
            paginas = numPag;
        }

        public int GetNumPaginas()
        {
            return paginas;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"El libro con ISBN: {isbn} creado por el autor: {autor} tiene {paginas} páginas");
        }
    }
}
