using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_categoria
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string categoria = "";
            double salario_minimo = 1200; 
            double salario_reajustado = 0;

            Console.WriteLine("=================");
            Console.WriteLine("AUMENTO SALARIAL");
            Console.WriteLine("=================");

            Console.WriteLine("Nome do Funcionário: ");
            nome = Console.ReadLine();

            Console.WriteLine("Categoria: ");
            categoria = Console.ReadLine().ToUpper();
            
            switch(categoria)
            {
                case "A":
                case "C":
                case "F":
                case "H":
                    Console.WriteLine("10% DE AUMENTO");
                    salario_reajustado = (salario_minimo + (salario_minimo * 0.1));
                    Console.Write("SEU SALÁRIO ACRESCIDO DO AUMENTO É DE: R$" + salario_reajustado);
                    break;

                case "B":
                case "D":
                case "E":
                case "I":
                case "J":
                case "T":
                    Console.WriteLine("15% DE AUMENTO");
                    salario_reajustado = (salario_minimo + (salario_minimo * 0.15));
                    Console.Write("SEU SALÁRIO ACRESCIDO DO AUMENTO É DE: R$" + salario_reajustado);
                    break;
                case "K":
                case "R":
                    Console.WriteLine("25% DE AUMENTO");
                    salario_reajustado = (salario_minimo + (salario_minimo * 0.25));
                    Console.Write("SEU SALÁRIO ACRESCIDO DO AUMENTO É DE: R$" + salario_reajustado);
                    break;

                case "L":
                case "M":
                case "N":
                case "O":
                case "P":
                case "Q":
                case "S":
                    Console.WriteLine("35% DE AUMENTO");
                    salario_reajustado = (salario_minimo + (salario_minimo * 0.35));
                    Console.Write("SEU SALÁRIO ACRESCIDO DO AUMENTO É DE: R$" + salario_reajustado);
                    break;

                case "U":
                case "V":
                case "X":
                case "Y":
                case "W":
                case "Z":
                    Console.WriteLine("50% DE AUMENTO");
                    salario_reajustado = (salario_minimo + (salario_minimo * 0.5));
                    Console.Write("SEU SALÁRIO ACRESCIDO DO AUMENTO É DE: R$" + salario_reajustado);
                    break;
                default:
                    Console.WriteLine("VOCÊ NÃO ESTÁ EM NENHUMA CATEGORIA DE FUNCIONÁRIOS DA EMPRESA");
                    break;
            }

            Console.ReadKey();



            
        }
    }
}
