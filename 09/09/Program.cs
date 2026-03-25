using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, media, soma;
            Console.WriteLine("A media do 1° bimestre: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("A media do 2° bimestre: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A media do 3° bimestre: ");
            n3 = int.Parse(Console.ReadLine());
            soma = n1 + n2 + n3;
            media = soma / 3;
            Console.WriteLine("A media do aluno é: " + media);



        }
    }
}
