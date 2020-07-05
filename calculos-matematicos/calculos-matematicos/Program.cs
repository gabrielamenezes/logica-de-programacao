using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculos_matematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // string é qualquer coisa entre aspas duplas
            // int é número inteiro
            // double é tipo numérico que trabalha com números racionais 
            //float é tipo numérico que trabalha com números racionais
            // bool tipo booleano que trabalha com true e false
            //parse é conversão
            //int.Parse
            //declaração de variável

            string nome = "";
            int numero1 = 0;
            int numero2 = 0;
            int soma = 0;
            int mult = 0;

            Console.WriteLine("Digite seu nome: " ); //escrever no console
            nome = Console.ReadLine();

            Console.WriteLine("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());
            soma = numero1 + numero2;
            mult = numero1 * numero2;
            Console.WriteLine("A soma desses dois números é: " + soma);
            Console.WriteLine("A multiplicação desses dois números é: " + mult);

            Console.ReadKey();
        }
    }
}
