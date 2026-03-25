using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, total;// cria variavel
            Console.WriteLine("escreva o primeiro numero");//cria o texto
            n1 = int.Parse(Console.ReadLine());// armazena o valor total do n1
            Console.WriteLine("escreva o segundo numero");//insere o texto
            n2 = int.Parse(Console.ReadLine());// armazena o valor total do n2
            total = n1 - n2;// a soma dos numeros
            Console.WriteLine("Esse é o numero " + total);// insere o texto com o valor do total


        }
    }
}
