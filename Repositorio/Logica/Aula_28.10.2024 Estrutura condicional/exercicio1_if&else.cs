using System;

namespace Aula_3
{
    class Exercicio1_If_Else
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor inicial do investimento: ");
            double valor_inicial = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Escolha o tipo de investimento: \n 1 - Poupança (3% ao ano) \n 2 - Renda Fixa (5% ao ano) \n 3 - Ações (10% ao ano, com 5% de chance de perda)");
            int tipo_investimento = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Quantos anos deseja investir?");
            int anos = int.Parse(Console.ReadLine());

            double saldo_final = valor_inicial;

            for (int ano = 1; ano <= anos; ano++)
            {
                double taxa = 0;
                if (tipo_investimento == 1)
                {
                    taxa = 1.03;
                }
                else if (tipo_investimento == 2)
                {
                    taxa = 1.05;
                }

                else if (tipo_investimento == 3)
                {
                    taxa = (ano % 4 == 0) ? 1.05 : 1.10;
                }

                else
                {
                    System.Console.WriteLine("Tipo de investimento inválido.");
                }

                saldo_final *= taxa;

                Console.WriteLine($"Saldo final após {ano}: R$ {saldo_final:F2}");
            }

        }
    }
}
