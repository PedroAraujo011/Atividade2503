using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeatual, idadefutura;
            Console.WriteLine("Digite sua idade atual: ");
            idadeatual = int.Parse(Console.ReadLine());
            idadefutura = idadeatual + 10;
            Console.WriteLine("Daqui 10 anos, voçê terá: " + idadefutura + "anos");
        }
    }
}
