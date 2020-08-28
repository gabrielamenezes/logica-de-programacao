using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relatorio_corretor
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = null;
            double venda = 0;
            double comissao = 0;

            Console.Write("Nome do corretor: ");
            nome = Console.ReadLine();

            Console.Write("Valor da venda: R$");
            venda = double.Parse(Console.ReadLine());

            Console.WriteLine("CALCULANDO SUA COMISSÃO...");

            if(venda > 50000)
            {
                Console.WriteLine("Sua comissão é de 12%");
                comissao = ((venda * 12) / 100);

            } else if (venda > 30000 && venda < 50000)
            {
                Console.WriteLine("Sua comissão é de 9.5%");
                comissao = ((venda * 9.5) / 100);
            } else
            {
                Console.WriteLine("Sua comissão é de 7%");
                comissao = ((venda * 7) / 100);
            }
            Console.WriteLine(nome + ", sua comissão é de: R$" + comissao);

            Console.ReadKey();
        }
    }
}
