using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("digite o numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segunda numero :");
            n2 = int.Parse(Console.ReadLine()); 
            if (n1 != n2)
            {
                Console.WriteLine("Os números é diferente.");
            }
            if (n1 == n2)
            {
                Console.WriteLine("Seu numero é igual");
            }

        }
    }
}
