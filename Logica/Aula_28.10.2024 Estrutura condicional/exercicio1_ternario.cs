using System;

namespace CalculadoraFinanceira
{
    class Exercicio1_Ternario
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor inicial do investimento:");
            double valorInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de investimento:");
            Console.WriteLine("1 - Poupança (3% ao ano)");
            Console.WriteLine("2 - Renda Fixa (5% ao ano)");
            Console.WriteLine("3 - Ações (10% ao ano com possibilidade de perda)");
            int tipoInvestimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de anos que deseja investir:");
            int anos = int.Parse(Console.ReadLine());

            double saldoFinal = valorInicial;

            // Uso de ternário para determinar o tipo de investimento
            saldoFinal = tipoInvestimento == 1 
                ? CalcularRendimento(saldoFinal, 0.03, anos) // Poupança
                : tipoInvestimento == 2 
                    ? CalcularRendimento(saldoFinal, 0.05, anos) // Renda Fixa
                    : tipoInvestimento == 3 
                        ? CalcularRendimento(saldoFinal, 0.10, anos) * 0.95 // Ações com perda de 5%
                        : -1; // Tipo inválido

            if (saldoFinal < 0)
            {
                Console.WriteLine("Tipo de investimento inválido.");
                return; // Encerra o programa se o tipo de investimento for inválido
            }

            Console.WriteLine($"O saldo final estimado após {anos} anos é: R$ {saldoFinal:F2}");
        }

        // Função para calcular rendimento anual
        static double CalcularRendimento(double valor, double taxa, int anos)
        {
            for (int i = 1; i <= anos; i++)
            {
                valor += valor * taxa;
            }
            return valor;
        }
    }
}
