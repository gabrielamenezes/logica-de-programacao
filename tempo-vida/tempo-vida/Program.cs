using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempo_vida
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int dias = 360; //total de dias em 1 ano
            int idade = 0;
            int tempo = 0;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            tempo = idade * dias;

            Console.WriteLine("Seu nome é " + nome + " e você viveu até hoje " + tempo + " dias");

            Console.ReadKey();



        }
    }
}
