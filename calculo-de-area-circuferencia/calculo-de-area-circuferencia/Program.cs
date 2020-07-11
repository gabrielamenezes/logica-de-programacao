using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_area_circuferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0;
            double raio = 0;

            Console.WriteLine("Raio: "); //request do raio
            raio = double.Parse(Console.ReadLine());
            area = (raio*raio) * 3.14;
            Console.WriteLine("A área da circunferência é " + area);

            Console.ReadKey();




        }
    }
}
