using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrado_e_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int quadrado = 0;
            int cubo = 0;

            Console.Write("Digite um número: ");
            valor = int.Parse(Console.ReadLine());
            quadrado = valor * valor;
            cubo = valor * valor * valor;

            Console.WriteLine("O número " + valor + " elevado ao quadrado é igual a: " + quadrado);
            Console.WriteLine("O número " + valor + " elevado ao cubo é igual a: " + cubo);
            Console.ReadKey();
        }
    }
}
