using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace troca_de_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            // faça um algoritmo que leia dois valores para as variáveis A e B e efetue a troca dos valores de forma que a variável A passe a possuir o valor da variávle B etc

            int A = 0;
            int B = 0;
            int aux_a = 0;
            int aux_b = 0;
      

            Console.WriteLine("Digite um número inteiro: ");
            A = int.Parse(Console.ReadLine());
            aux_a = A;
   
            Console.WriteLine("Digite outro número inteiro: ");
            B = int.Parse(Console.ReadLine());
            aux_b = B;
            B = aux_a;
            A = aux_b;
            

   
            


            Console.WriteLine("Efetuando a troca de valores...");

            Console.WriteLine("O valor do primeiro número agora vale: " + A);
            Console.WriteLine("O valor do segundo número agora vale: " + B);

            Console.ReadKey();
        }
    }
}
