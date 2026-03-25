using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero, dobro;
            Console.WriteLine("Escreva o primeiro numero");
            Numero = int.Parse(Console.ReadLine());
            dobro = Numero * 2;
            Console.WriteLine("O dobro do numero " + Numero + " é " + dobro);
        }
    }
}
