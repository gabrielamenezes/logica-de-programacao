using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double val1 = 0;
            double val2 = 0;
            double media = 0;

            Console.Write("Coloque sua 1° nota: ");
            val1 = double.Parse(Console.ReadLine());


            Console.Write("Coloque sua 2° nota: ");
            val2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Calculando sua média...");
            media = val1 + val2 / 2;

            Console.WriteLine("Média é: " + media);

            Console.ReadKey();
        }
    }
}
