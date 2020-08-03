using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace mediafinal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Primeira prova: Peso 2 */
            /* Segunda prova: Peso 3 */
            /* Terceira prova: Peso 5 */
            string nome = null;
            double prova1 = 0;
            double prova2 = 0;
            double prova3 = 0;
            double mediafinal = 0;

            Console.WriteLine("Bem vindo ao sistema de Média Final da IES");
            Console.Write("Nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Nota da primeira prova: ");
            prova1 = int.Parse(Console.ReadLine());

            Console.Write("Nota da segunda prova: ");
            prova2 = int.Parse(Console.ReadLine());

            Console.Write("Nota da terceira prova: ");
            prova3 = int.Parse(Console.ReadLine());


            prova1 = prova1 * 2;
            prova2 = prova2 * 3;
            prova3 = prova3 * 5;

            mediafinal = (prova1 + prova2 + prova3) / 3;

            if(mediafinal > 70)
            {
                Console.Write("Parabéns, " + nome + ", você passou com " +mediafinal +  " pontos de média");
            } else
            {
                Console.Write("Sinto muito, " + nome + ", você foi reprovado! Sua média foi " + mediafinal);
            }
            

            Console.ReadKey();
        }
    }
}
