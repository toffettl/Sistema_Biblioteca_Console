using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca b = new Biblioteca();
            string opcao;
            int valorLivro = 0;

            do
            {
                Console.WriteLine("Digite 'adicionar' para adicionar livro");
                Console.WriteLine("Digite 'listar' para listar livro");
                Console.WriteLine("Digite 'remover' para listar livro");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "adicionar":
                        Console.WriteLine("Digite o nome do livro");
                        string nomeLivro = Console.ReadLine();
                        Console.WriteLine("Digite o autor do livro");
                        string autorLivro = Console.ReadLine();
                        Console.WriteLine("Digite a data do livro");
                        string dataLivro = Console.ReadLine();
                        Livro l = new Livro(nomeLivro, autorLivro, dataLivro);
                        valorLivro += 1;
                        b.adicionarLivro(valorLivro,l);
                        break;

                    case "listar":
                        b.listarLivros();
                        break;

                    case "remover":
                        Console.WriteLine("Digite o valor do livro");
                        valorLivro = Convert.ToInt32(Console.ReadLine());
                        b.removerLivro(valorLivro);
                        break;
                }
            } while ((opcao != "sim") && (opcao != "não"));
        }
    }
}
