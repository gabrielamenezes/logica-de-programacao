using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litros_de_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALCULAR A QUANTIDADE DE LITROS
            //automóvel faz 12km por litro;
            // distancia = tempo * velocidade
            // litros_usados = distancia/12
            double tempo = 0;
            double velocidadeM = 0;
            double distancia = 0;
            double litros_usados = 0;


            Console.WriteLine("Qual foi o tempo gasto na viagem? ");
            tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Velocidade média: ");
            velocidadeM = double.Parse(Console.ReadLine());

            distancia = tempo * velocidadeM;

            litros_usados = distancia / 12;
            Console.WriteLine("A  velocidade média durante a viagem foi " + velocidadeM + " km/h");
            Console.WriteLine("O tempo gasto na viagem foi " + tempo + " horas");
            Console.WriteLine("A distância percorrida na viagem foi " + distancia + " km");
            Console.WriteLine("Foram gastos " + litros_usados + " litros de combustível na viagem");
            Console.ReadKey();
        }
    }
}
