using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_f2_f3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;

            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero <= 10)
            {
                Console.Write("F1");
            } else if (numero > 10 && numero <= 100)
            {
                Console.Write("F2");
            } else if (numero > 100)
            {
                Console.Write("F3");
            } 

            Console.ReadKey();
        }
    }
}
