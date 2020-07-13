using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace troca_ordem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = 0;
            int numB = 0;

            Console.Write("Digite um número: ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            numB = int.Parse(Console.ReadLine());

            Console.WriteLine("Os números digitados foram: " + numB + " e " + numA);

            Console.ReadKey();
        }
    }
}
