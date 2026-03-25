using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
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

            double menor = n1;

            if (n2 < menor) menor = n2;
            if (n3 < menor) menor = n3;
            if (n4 < menor) menor = n4;
            if (n5 < menor) menor = n5;

            Console.WriteLine("O menor número é: " + menor);
        }
    }
}
