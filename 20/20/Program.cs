using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5;

            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o quarto número: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o quinto número: ");
            n5 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
            {
                Console.WriteLine("O maior número é: " + n1);
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
            {
                Console.WriteLine("O maior número é: " + n2);
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                Console.WriteLine("O maior número é: " + n3);
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
            {
                Console.WriteLine("O maior número é: " + n4);
            }
            else if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4)
            {
                Console.WriteLine("O maior número é: " + n5);
            }
            else
            {
                Console.WriteLine("Há números iguais ou não foi possível determinar um único maior.");
            }   }
    }
}
