using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrado_da_soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int soma = 0;
            int quadrado = 0;

            Console.WriteLine("Quadrado da soma de dois valores");
            Console.Write("Digite um número: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            B = int.Parse(Console.ReadLine());

            soma = A + B;
            quadrado = soma * soma;

            Console.WriteLine("O quadrado da soma de " + A + " + " + B + " é: " + quadrado);
            Console.ReadKey();
        }
    }
}
