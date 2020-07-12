using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propriedade_distributiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int soma1 = 0;
            int soma2 = 0;
            int soma3 = 0;
            int soma4 = 0;
            int soma5 = 0;
            int soma6 = 0;


            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D: ");
            D = int.Parse(Console.ReadLine());
            soma1 = A + B;
            soma2 = A + C;
            soma3 = A + D;
            soma4 = B + C;
            soma5 = B + D;
            soma6 = C + D;

            Console.WriteLine("Iniciando propriedade distributiva...");
            Console.WriteLine("A * B = " + A * B);
            Console.WriteLine("A * C = " + A * C);
            Console.WriteLine("A * D = " + A * D);
            Console.WriteLine("B * C = " + B * C);
            Console.WriteLine("B * D = " + B * D);
            Console.WriteLine("C * D = " + C * D);

            Console.WriteLine("Iniciando soma...");
            Console.WriteLine("A + B = " + soma1);
            Console.WriteLine("A + C = " + soma2);
            Console.WriteLine("A + D = " + soma3);
            Console.WriteLine("B + C = " + soma4);
            Console.WriteLine("B + D = " + soma5);
            Console.WriteLine("C + D = " + soma6);
            
            Console.ReadKey();
        }
    }
}
