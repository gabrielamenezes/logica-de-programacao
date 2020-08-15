using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_provas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = null;
            int media_final = 0;
            int nota_pt = 0;
            int nota_mat = 0;
            int nota_cg = 0;

            Console.WriteLine("BEM VINDO AO SISTEMAS DE NOTAS DO VESTIBULAR 2020");
            Console.Write("Nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Candidato(a), " + nome + ", insira suas notas abaixo");
            Console.Write("Nota em Português: ");
            nota_pt = int.Parse(Console.ReadLine());

            Console.Write("Nota em Matemática: ");
            nota_mat = int.Parse(Console.ReadLine());

            Console.Write("Nota em Conhecimentos Gerais: ");
            nota_cg = int.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS REGISTRADAS:");
            Console.WriteLine("PORTUGUÊS: " + nota_pt);
            Console.WriteLine("MATEMÁTICA: " + nota_mat);
            Console.WriteLine("NOTA EM CONHECIMENTOS GERAIS: " + nota_cg);

            Console.WriteLine("CALCULANDO MÉDIA.....");
            media_final = ((nota_mat + nota_pt + nota_cg) / 3);

            if (media_final > 7 && nota_pt > 5 && nota_mat > 5 && nota_cg > 5)
            {
                Console.WriteLine("APROVADO(A)!");
            } else
            {
                Console.WriteLine("REPROVADO(A)!");
            }
            Console.ReadKey();
        }
    }
}
