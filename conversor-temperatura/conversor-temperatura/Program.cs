using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausF = 0; //temperatura em fahrenheit
            double grausC = 0; //temperatura em celsius

            // formula de conversão F = (9*C + 160)/5

            Console.WriteLine("Digite a temperatura em Celsius: ");
            grausC = double.Parse(Console.ReadLine());

            grausF = ((9 * grausC) + 160) / 5;

            Console.WriteLine("A temperatura em celsius " + grausC + " convertida para fahrenheit é: " + grausF);
      
            Console.ReadKey();


        }
    }
}
