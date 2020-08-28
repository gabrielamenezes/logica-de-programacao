using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace troco_dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor_compra = 0;
            // CAIXA COM NOTAS DE 1, 10 E 100 REAIS

            Console.WriteLine("BEM VINDO AO CAIXA DO MERCADO DIGITAL");
            Console.Write("VALOR DA SUA COMPRA R$: ");
            valor_compra = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
