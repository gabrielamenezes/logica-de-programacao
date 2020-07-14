using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_salario_liquido
{
    class Program
    {
        static void Main(string[] args)
        {
            //descontam-se inicialmente 10% do SB como previdência
            // após os 10%, são descontados +5% sobre o valor restante do SB
            double salario_bruto = 0;
            double valor_desconto = 0;
            double salario_liquido = 0;
            double salario_descontado = 0;
            double valor_imposto = 0;
            salario_liquido = 0;

            Console.Write("Seu salário bruto: ");
            salario_bruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Retirando 10% de contribuição para a previdência social...");
            valor_desconto = salario_bruto * 0.1;
            salario_descontado = salario_bruto - valor_desconto;
            Console.WriteLine("Seu salário - Contribuição à Previdência Social = " +salario_descontado);

            Console.WriteLine("Retirando 5% de imposto...");
            valor_imposto = salario_descontado * 0.5;
            salario_liquido = salario_descontado - valor_imposto;
            Console.WriteLine("Seu salário líquido é: " +salario_liquido);

            Console.ReadKey(); 

       
        }
    }
}
