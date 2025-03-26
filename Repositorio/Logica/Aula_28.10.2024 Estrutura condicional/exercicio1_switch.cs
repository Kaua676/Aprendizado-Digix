using System;

namespace CalculadoraFinanceira
{
    class Exercicio1_Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor inicial do investimento: ");
            double valor_inicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de investimento: \n 1 - Poupança (3% ao ano) \n 2 - Renda Fixa (5% ao ano) \n 3 - Ações (10% ao ano, com 5% de perda ao final)");
            int tipo_investimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos anos deseja investir?");
            int anos = int.Parse(Console.ReadLine());

            double saldo_final = valor_inicial;

            switch (tipo_investimento)
            {
                case 1:
                    saldo_final = CalcularRendimento(saldo_final, 0.03, anos);
                    break;
                case 2:
                    saldo_final = CalcularRendimento(saldo_final, 0.05, anos);
                    break;
                case 3:
                    double saldoComRendimento = CalcularRendimento(saldo_final, 0.10, anos);
                    double saldoComPerda = saldoComRendimento - (saldoComRendimento * 0.05);
                    
                    Console.WriteLine($"Após {anos} anos, com 10% de rendimento: R$ {saldoComRendimento:F2}");
                    Console.WriteLine($"Após aplicar a perda de 5%: R$ {saldoComPerda:F2}");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    return; 
            }

            Console.WriteLine($"Saldo final: R$ {saldo_final:F2}");
        }

        static double CalcularRendimento(double saldo, double taxa, int anos)
        {
            for (int i = 1; i <= anos; i++)
            {
                saldo += saldo * taxa;
                Console.WriteLine($"Ano {i}: R$ {saldo:F2}");
            }
            return saldo;
        }
    }
}
