using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite o primeiro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("O maior numero é: " + n1);
            }
            else if (n1 < n2)
            {
                Console.WriteLine("O maior numero é: " + n2);
            }

            }
    }
}
