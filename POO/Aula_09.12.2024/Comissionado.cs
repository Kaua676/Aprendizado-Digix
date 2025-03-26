using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public class Comissionado : Empregado
    {
        public double totalVenda;
        public double taxaComissao;

        public Comissionado(string nome, string sobrenome, string cpf, double totalvenda, double taxacomissao) : base(nome, sobrenome, cpf)
        {
            this.totalVenda = totalvenda;
            this.taxaComissao = taxacomissao;
        }

        public override double Vencimento()
        {
            return totalVenda * taxaComissao;
        }

        public override void imprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Sobrenome:" + sobreNome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Total de venda: " + totalVenda);
            System.Console.WriteLine("Taxa de Comissão: " + taxaComissao);
            System.Console.WriteLine("Total: " + Vencimento());
        }
    }
}