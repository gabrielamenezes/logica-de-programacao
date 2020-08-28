using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peças_mecanicas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int qntd_parafusos = 0;
            int qntd_porcas = 0;
            int qntd_arruelas = 0;

            Console.WriteLine("---------------------------");
            Console.WriteLine("BEM VINDO(A) AO MECANSHOP");
            Console.WriteLine("--------------------------");
            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("PRODUTOS DISPONÍVEIS: ");
            Console.WriteLine("PARAFUSOS, PORCAS E ARRUELAS");
            Console.WriteLine("PARAFUSOS: R$10");
            Console.WriteLine("PORCAS: R$25");
            Console.WriteLine("ARRUELAS: R$30");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("SETOR DE COMPRAS");
            Console.WriteLine("-------------------------------");
            Console.Write("Quantidade de parafusos: ");
            qntd_parafusos = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de porcas: ");
            qntd_porcas = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de arruelas: ");
            qntd_arruelas = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("DESCONTOS");
            Console.WriteLine("--------------------");
            Console.WriteLine("PORCAS: 10% SOBRE O VALOR UNITÁRIO");
            Console.WriteLine("PARAFUSOS: 20% SOBRE O VALOR UNITÁRIO");
            Console.WriteLine("ARRUELAS: 30% SOBRE O VALOR UNITÁRIO");
            Console.ReadKey();


            
        }
    }
}
