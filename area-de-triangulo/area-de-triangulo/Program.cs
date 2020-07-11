using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_de_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0;
            double Base = 0;
            double altura = 0;
            string nome = "";
            string sobrenome = "";
            string NomeCompleto = "";

            Console.WriteLine("Digite seu nome para calcular a área do triângulo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Agora digite o seu sobrenome: ");
            sobrenome = Console.ReadLine();
            NomeCompleto = nome + " " + sobrenome;
            Console.WriteLine("O seu nome completo é: " + NomeCompleto);

            Console.WriteLine("base do triângulo: ");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("altura do triângulo: ");
            altura = double.Parse(Console.ReadLine());

            area = (Base * altura) / 2;
            Console.WriteLine("A área do triângulo é: " + area);


            Console.ReadKey();
        }
    }
}
