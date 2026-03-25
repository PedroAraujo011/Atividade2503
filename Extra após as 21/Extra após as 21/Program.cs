using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_após_as_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            int anoNascimento;
            int anoIngresso;
            int idade;
            int tempoTrabalho;
            int anoAtual = DateTime.Now.Year;

            Console.Write("Digite o código do empregado: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de ingresso na empresa: ");
            anoIngresso = int.Parse(Console.ReadLine());

            idade = anoAtual - anoNascimento;
            tempoTrabalho = anoAtual - anoIngresso;

            Console.WriteLine("\nIdade: " + idade);
            Console.WriteLine("Tempo de trabalho: " + tempoTrabalho);

            if (idade >= 65 ||
                tempoTrabalho >= 30 ||
                (idade >= 60 && tempoTrabalho >= 25))
            {
                Console.WriteLine("Requerer aposentadoria");
            }
            else
            {
                Console.WriteLine("Não requerer");
            }
        }
    }
}
