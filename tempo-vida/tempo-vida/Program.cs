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
            int dia = 0;
            int mes = 0;
            int ano = 0;
            int ano_atual = 2020;
            int count_dia = 0;
            int convert_year = 0;
            int convert_month = 0;
            //numero de dias que uma pessoa já viveu
            Console.WriteLine("Dia do seu nascimento: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano: ");
            ano = int.Parse(Console.ReadLine());

            convert_year = (((2020 - ano) * 12) * 30);
            convert_month = mes * 30;
            count_dia = dia + convert_month + convert_year;
            Console.WriteLine("Você viveu " + count_dia + " dias");

            Console.ReadKey();



        }
    }
}
