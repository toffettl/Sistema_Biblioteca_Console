using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    class Biblioteca
    {
        Dictionary<int, Livro> listaLivro = new Dictionary<int, Livro>();

        public void adicionarLivro(int chave, Livro livro)
        {
            listaLivro.Add(chave, livro);
        }

        public void removerLivro(int chave)
        {
            listaLivro.Remove(chave);
        }

        public void listarLivros()
        {
            foreach(KeyValuePair<int, Livro> item in listaLivro)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
