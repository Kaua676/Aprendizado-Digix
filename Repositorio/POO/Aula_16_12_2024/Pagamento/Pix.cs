using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024
{
    public class Pix : IPagamento
    {
        public string chavePix { get; set; }

        public string nomeTitular { get; set; }

        public string CPF { get; set; }

        public double Valor { get; set; }

        public DateTime dataPagamento { get; set; }

        // Construtor
        public Pix(string chavepix, string nometitular, string cpf, double valor, DateTime datapagamento)
        {
            chavePix = chavepix;
            nomeTitular = nometitular;
            CPF = cpf;
            Valor = valor;
            dataPagamento = datapagamento;
        }

        public void RealizarPagamento(double valor)
        {
            Valor = valor;
            System.Console.WriteLine($"------------------------------\nPagamento realizado com sucesso via PIX de R$ {valor}");
        }

        public void ExibirComprovante()
        {
            System.Console.WriteLine("Comprovante de pagamento via PIX");
            System.Console.WriteLine($"Chave PIX: {chavePix}\n ------------------------------");
        }
    }
}