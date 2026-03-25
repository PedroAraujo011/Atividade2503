using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite seu numero");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0) Console.WriteLine("O Numero " + numero + " e par ");
            else
            Console.WriteLine( "Seu numero " + numero + "impar");

        }
    }
}
