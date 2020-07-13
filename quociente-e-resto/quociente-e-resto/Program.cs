using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quociente_e_resto
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = 0;
            int int2 = 0;

            Console.Write("Digite um número: ");
            int1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número : ");
            int2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A divisão de " + int1 + " por " + int2 + " é: " + int1 / int2);
            Console.WriteLine("O resto da divisão " + int1 + " por " + int2 + " é " + int1 % int2);

            Console.ReadKey();
        }
    }
}
