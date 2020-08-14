using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordem_crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Digite 3 números e iremos apresentá-los em ordem crescente");
            Console.Write("Numero 1: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("Numero 3: ");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                if (numero2 > numero3)
                {
                    Console.WriteLine("A ordem dos números é: " + numero1 + " " + numero2 + " " + numero3);
                } else if (numero3 > numero2)
                {
                    Console.WriteLine("A ordem dos números é: " + numero1 + " " + numero3 + " " + numero2);
                }
            }

            if (numero2 > numero1 && numero2 > numero3)
            {
                if (numero1 > numero3)
                {
                    Console.WriteLine("A ordem dos números é: " + numero2 + " " + numero1 + " " + numero3);
                }
                else if (numero3 > numero1)
                {
                    Console.WriteLine("A ordem dos números é: " + numero2 + " " + numero3 + " " + numero1);
                }
            }

            if (numero3 > numero1 && numero3 > numero2)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine("A ordem dos números é: " + numero3 + " " + numero1 + " " + numero2);
                }
                else if (numero2 > numero1)
                {
                    Console.WriteLine("A ordem dos números é: " + numero3 + " " + numero2 + " " + numero1);
                }
            }
            Console.ReadKey();
        }
    }
}
                
