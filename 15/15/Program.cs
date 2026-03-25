using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("digite o numero:");
            n1 = int.Parse(Console.ReadLine());
            if (n1 > 100)
            {
                Console.WriteLine("Seu numero é maior que 100: ");
            }
            else Console.WriteLine("seu numero é menor que 100: ");
        }
    }
}
