using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper.Utilizando_array_e_listas
{
    using System;
    class Program
    {
        static void Main()
        {
            var quantidadeJogos = int.Parse(Console.ReadLine());
            var nomesJogos = new string[quantidadeJogos];

            for (int i = 0; i < quantidadeJogos; i++)
            {
                AdicionarJogo(i, nomesJogos);
            }

            ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
        }

        static void AdicionarJogo(int indice, string[] nomes)
        {
            nomes[indice] = Console.ReadLine();
        }

        static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
        {
            Console.WriteLine($"\nFoi adicionado '{quantidadeJogos}' jogos: {string.Join(", ", nomes)} ao catalogo.");
        }
    }
