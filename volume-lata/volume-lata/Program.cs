using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume_lata
{
    class Program
    {
        static void Main(string[] args)
        {
            // VOLUME = 3.14 * RAIO **2 * ALTURA

            double volume = 0;
            double raio = 0;
            double altura = 0;

            Console.WriteLine("Valor do raio: ");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor altura ");
            altura = double.Parse(Console.ReadLine());

            volume = ((3.14 * (raio * raio)) * altura);
            Console.WriteLine("O volume da lata é " + volume);
            Console.ReadKey();

        }
    }
}
