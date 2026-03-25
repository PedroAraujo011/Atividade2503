using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Leias dis números e moste a soma deles 
            int n1, n2, n3;// cria a variavel
            Console.WriteLine("Escreva o primeiro número :");//insere o texto
            n1 = int .Parse(Console.ReadLine());//armazenado o valor no n1 
            Console.WriteLine("Escreva o segundo número :");//insere texto
            n2 = int.Parse(Console.ReadLine());//armazena valor no n2
            n3 = n1 + n2;// soma
            Console.WriteLine("Esse e o resultado da soma " + n3);//insere o texto com valor de n3
        }
    }
}
