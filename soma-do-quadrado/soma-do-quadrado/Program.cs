using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_do_quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int soma = 0;

            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());
            
            Console.Write("Digite outro número: ");
            b = int.Parse(Console.ReadLine());

            soma = ((a * a) + (b * b));
            Console.WriteLine("Os valores digitados foram: " + a + " e " + b);
            Console.WriteLine("A soma do quadrado de cada valor lido é " + soma);


            Console.ReadKey();
        }
    }
}
