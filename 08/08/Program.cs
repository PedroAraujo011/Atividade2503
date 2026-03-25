using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, antecessor, sucessor;
            Console.WriteLine("Digite seu numero");
            numero = int.Parse(Console.ReadLine());
            antecessor = numero - 1;
            sucessor = numero + 1;
            Console.WriteLine("o antecessor de " + numero + " e " + antecessor);
            Console.WriteLine("o sucessor de " + numero + " e " + sucessor);
                

        }
    }
}
