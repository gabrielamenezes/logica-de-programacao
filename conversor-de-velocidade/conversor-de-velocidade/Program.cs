using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_de_velocidade
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = 0;
            double ms = 0;

            Console.WriteLine("CONVERSOR DE VELOCIDADE");
            Console.Write("Digite sua velocidade em Km/h: ");
            km = double.Parse(Console.ReadLine());
            ms = km / 3.6;

            Console.WriteLine("Sua velocidade: " +km + "km/h");
            Console.WriteLine("Conversão: " +ms + " m/s");
            Console.ReadKey();
        }
    }
}
