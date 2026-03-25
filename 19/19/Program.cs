using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kmPercorrida, litrosConsumidos, consumoMedio;
            Console.WriteLine("digite a distancia total percorrida (km): ");
            kmPercorrida = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o total de litros e combustiveis consumidos : ");
            litrosConsumidos = int.Parse(Console.ReadLine());
            if (litrosConsumidos > 0)
            {
                consumoMedio = kmPercorrida / litrosConsumidos;
                Console.WriteLine("O consumo médio do carro é: " + consumoMedio + " km/l");
            }
            else
            { 
                Console.WriteLine("Erro: A quantidade de litros deve ser maior que zero.");
            }
            
        }
    }
}
