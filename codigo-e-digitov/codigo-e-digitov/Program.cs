using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_e_digitov
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo = "";
            int digitov = 0;
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int E = 0;
            int S = 0; // variável para achar o digitov

            Console.Write("Digite seu código de 5 algarismos: ");
            codigo = Console.ReadLine();
            A = int.Parse(codigo.Substring(0, 1));
            B = int.Parse(codigo.Substring(1, 1));
            C = int.Parse(codigo.Substring(2, 1));
            D = int.Parse(codigo.Substring(3, 1));
            E = int.Parse(codigo.Substring(4, 1));

            S = 6 * A + 5 * B + 4 * C + 3 * D + 2 * E;

            digitov = S % 7;

            Console.WriteLine("Seu digito verificador é = " +digitov);
            Console.ReadKey();

            
        }
    }
}
