using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper.Dominando_os_operadores
{
    using System;

    class Program
    {
        static void Main()
        {
            string titulo;
            string descricao;
            string dataVencimento;

            titulo = Console.ReadLine();
            descricao = Console.ReadLine();

            if (descricao.Length > 50)
                Console.WriteLine("Descricao ultrapassa limite de caracteres.");
            else
            {
                dataVencimento = Console.ReadLine();
                Console.WriteLine(descricao + " ate " + dataVencimento);
            }
        }
    }

