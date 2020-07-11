using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheit_to_celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausF = 0;
            double grausC = 0;

            // C = (F-32) * (5/9)

            Console.WriteLine("Digite a temperatura em Fahreheit: ");
            grausF = double.Parse(Console.ReadLine());
            grausC = ((grausF - 32) * 5/9);

            Console.WriteLine("A temperatura em celsisus é " + grausC);
            Console.ReadKey();
        }
    }
}
