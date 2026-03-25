using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            
            if (numero >= 10 && numero <= 50)
            {
                Console.WriteLine("O número " + numero + " está entre 10 e 50.");
            }
            else
            {
                Console.WriteLine("O número " + numero + " não está entre 10 e 50.");
            }
        }
    }
}
