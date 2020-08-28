using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmo_picole
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipo = 0;
            double total_arrecadado = 0;
            double quantidade_vendida = 0;
            //tipo 1 - R$0.50
            //tipo 2 - R$0.60
            //tipo 3 - R$0.75

            Console.WriteLine("ESCOLHA SEU PICOLÉ");
            Console.WriteLine("TIPO 1 - R$0.50");
            Console.WriteLine("TIPO 2 - R$0.60");
            Console.WriteLine("TIPO 3 - R$0.75");

            Console.WriteLine("TIPO DESEJADO: ");
            tipo = int.Parse(Console.ReadLine());

            Console.WriteLine("QUANTIDADE: ");
            quantidade_vendida = int.Parse(Console.ReadLine());

            if(tipo == 1)
            {
                Console.WriteLine("VOCÊ ESTÁ COMPRANDO O PICOLÉ TIPO " + tipo);
                Console.WriteLine("QUANTIDADE: " + quantidade_vendida);
                Console.WriteLine("ESSE PICOLÉ CUSTA 50 CENTAVOS");
                total_arrecadado = (quantidade_vendida * 0.50);
                Console.WriteLine("VALOR TOTAL: R$" + total_arrecadado);
            } else if(tipo == 2)
            {
                Console.WriteLine("VOCÊ ESTÁ COMPRANDO O PICOLÉ TIPO " + tipo);
                Console.WriteLine("QUANTIDADE: " + quantidade_vendida);
                Console.WriteLine("ESSE PICOLÉ CUSTA 60 CENTAVOS");
                total_arrecadado = (quantidade_vendida * 0.60);
                Console.WriteLine("VALOR TOTAL: R$" + total_arrecadado);
            } else if(tipo == 3)
            {
                Console.WriteLine("VOCÊ ESTÁ COMPRANDO O PICOLÉ TIPO " + tipo);
                Console.WriteLine("QUANTIDADE: " + quantidade_vendida);
                Console.WriteLine("ESSE PICOLÉ CUSTA 75 CENTAVOS");
                total_arrecadado = (quantidade_vendida * 0.75);
                Console.WriteLine("VALOR TOTAL: R$" + total_arrecadado);
            } else
            {
                Console.WriteLine("VALOR INVÁLIDO");
            }

            Console.ReadKey();
        }
    }
}
