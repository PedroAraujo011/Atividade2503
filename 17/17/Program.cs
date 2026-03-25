using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario;

            Console.Write("Qual é o seu salário? ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario < 2000.0)
            {
                novoSalario = salario + (salario * 0.10);
                Console.WriteLine("Salário com aumento de 10%: R$ " + novoSalario);
            }
            else
            {
                Console.WriteLine("Salário não sofreu aumento: R$ " + salario);
            }

        }
    }
}
