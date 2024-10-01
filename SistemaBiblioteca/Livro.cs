using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    class Livro
    {
        public string Titulo;
        public string Autor;
        public string Data;

        public Livro (string titulo, string autor, string data)
        {
            Titulo = titulo;
            Autor = autor;
            Data = data;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor} ({Data})";
        }
    }
}
