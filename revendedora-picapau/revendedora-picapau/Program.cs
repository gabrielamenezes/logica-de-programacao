using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revendedora_picapau
{
    class Program
    {
        static void Main(string[] args)
        {
            //salario minimo = 1200
            // dois salários mínimos fixos + 50 reais por carro vendido + 5% do valor das vendas
            double salario_total = 0;
            string nome_vendedor = "";
            double porcentagem_vendas = 0;
            int total_vendas = 0;
            double salario_minimo = 1200;

            Console.WriteLine("-------------------");
            Console.WriteLine("REVENDEDORA PICA-PAU");
            Console.WriteLine("--------------------");

            Console.Write("Nome do vendedor: ");
            nome_vendedor = Console.ReadLine();
            Console.Write("Carros vendidos no mês: ");
            total_vendas = int.Parse(Console.ReadLine()) * 50;
            porcentagem_vendas = total_vendas * 0.05;
            salario_total = (salario_minimo * 2) + total_vendas + porcentagem_vendas;

            Console.WriteLine("---------------");
            Console.WriteLine("PAYMENT");
            Console.WriteLine("----------------");

            Console.WriteLine("Nome do funcionário: " + nome_vendedor);
            Console.WriteLine("Comissão de carros vendidos: R$" + total_vendas);
            Console.WriteLine("SALÁRIO FINAL: R$" + salario_total);

            Console.ReadKey();
        }
    }
}
