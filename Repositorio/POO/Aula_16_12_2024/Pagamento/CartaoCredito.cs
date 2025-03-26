using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024
{
    public class CartaoCredito : IPagamento, IAnuidade
    {
        public string numeroCartao { get; set; }
        public DateTime dataVencimento { get; set; }
        public double valorAnuidade { get; set; }
        // Construtor
        public CartaoCredito(string numeroCartao, DateTime dataVencimento, double valorAnuidade)
        {
            this.numeroCartao = numeroCartao;
            this.dataVencimento = dataVencimento;
            this.valorAnuidade = valorAnuidade;
        }

        public void RealizarPagamento(double valor)
        {
            System.Console.WriteLine($"------------------------------\nPagamento de R$ {valor} realizado com sucesso com o cartão {numeroCartao} no dia {dataVencimento}");
        }

        public void ExibirComprovante()
        {
            System.Console.WriteLine($"Comprovante de pagamento com o cartão {numeroCartao}\n------------------------------");
        }

        // Importar a interface IAnuidade
        public DateTime CalcularDataVencimento()
        {
            return DateTime.Now.AddYears(1);
        }

        public double CalcularValorAnuidade()
        {
            return 100; // Valor fixo da anuidade
        }
    }
}