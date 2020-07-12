using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume_da_caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            // VOLUME = COMPRIMENTO * LARGURA * ALTURA
            double volume = 0;
            double comprimento = 0;
            double largura = 0;
            double altura = 0;

            Console.Write("Comprimento da caixa: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.Write("Largura: ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            altura = double.Parse(Console.ReadLine());

            volume = comprimento * largura * altura;

            Console.WriteLine("O volume da sua caixa retangular é de " + volume);

            Console.ReadKey();
        }
    }
}
