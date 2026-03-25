using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Escreva o primeiro numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero");
            n2 = int.Parse(Console.ReadLine());
            n3 = n1 / n2;
            Console.WriteLine("O total da conta é " + n3);



        }
    }
}
