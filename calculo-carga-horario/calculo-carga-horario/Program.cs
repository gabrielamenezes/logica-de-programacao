using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_carga_horario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            double horas_trabalhadas = 0; //horas trabalhadas no mês 
            double valor_hora = 0; //valor da hora trabalhada
            double percentual_desconto = 0; //percentual de desconto
            double salario_bruto = 0; //salario bruno
            double total_desconto = 0; // total desconto
            double salario_liquido = 0; //salario liquido

            Console.WriteLine("Digite seu nome para iniciar "); //pede nome do usuário
            nome = Console.ReadLine(); //atribui nome do usuário à variável nome
            Console.WriteLine("Horas trabalhadas no mês: ");
            horas_trabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de hora trabalhada: ");
            valor_hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Percentual de desconto: ");
            percentual_desconto = double.Parse(Console.ReadLine());

            //salario bruto = hora trabalhada * valor da hora
            salario_bruto = (horas_trabalhadas * valor_hora);

            //total desconto = percentual de desconto/100 * salario bruto
            total_desconto = (percentual_desconto / 100) * salario_bruto;

            //salario liquido = salario bruto - total de desconto
            salario_liquido = (salario_bruto - total_desconto);

            Console.WriteLine("Olá " + nome + "!" + " você tem um total de " + horas_trabalhadas + "," + " O seu salário bruto é de " + salario_bruto + ". O desconto foi de " + total_desconto + ", e o salário liquido é de " + salario_liquido);

            Console.ReadKey();

        }
    }
}
