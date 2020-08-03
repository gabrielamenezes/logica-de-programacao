using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 0;

            Console.Write("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());

            if(A > B)
            {
                Console.Write("O maior valor digitado foi " + A);
            } else if (B > A)
            {
                Console.Write("O maior valor digitado foi " + B);
            } else
            {
                Console.Write("Os valores são iguais");
            }


            Console.ReadKey();
        }
    }
}
