using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artigos_loja
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_comprador = null;
            double total_compra = 0;
            double artigo1 = 0;
            double artigo2 = 0;
            double artigo3 = 0;
            double artigo4 = 0;

            Console.WriteLine("LOJA DE ARTIGOS");
            Console.WriteLine("---------------");
            Console.Write("Nome: ");
            nome_comprador = Console.ReadLine();

            artigo1 = 140 - (140 * 0.15);
            artigo2 = 320 - (320 * 0.1);
            artigo3 = 150 - (150 * 0.05);
            artigo4 = 50 - (50 * 0.2);
            Console.WriteLine("======================");
            Console.WriteLine("HISTÓRICO DE COMPRA: ");
            Console.WriteLine("======================");
            Console.WriteLine("Nome do comprador: " + nome_comprador);
            Console.WriteLine("ARTIGO 1: In the hills");
            Console.WriteLine("PREÇO: R$140");
            Console.WriteLine("PORCENTAGEM DESCONTO: 15%");
            Console.WriteLine("PREÇO FINAL:" + artigo1);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("ARTIGO 2: CTV3");
            Console.WriteLine("PREÇO: R$320");
            Console.WriteLine("DESCONTO: 10%");
            Console.WriteLine("PREÇO FINAL:" + artigo2);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("ARTIGO 3: LUCY!");
            Console.WriteLine("PREÇO: R$150");
            Console.WriteLine("DESCONTO: 5%");
            Console.WriteLine("PREÇO FINAL:" + artigo3);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("ARTIGO 4: ABC");
            Console.WriteLine("PREÇO: R$50");
            Console.WriteLine("DESCONTO: 20%");
            Console.WriteLine("PREÇO FINAL:" + artigo4);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("CALCULANDO TOTAL A PAGAR....");
            total_compra = (artigo1 + artigo2 + artigo3 + artigo4);
            Console.Write("TOTAL A PAGAR....................." + total_compra);
            Console.ReadKey();

        }
    }
}
