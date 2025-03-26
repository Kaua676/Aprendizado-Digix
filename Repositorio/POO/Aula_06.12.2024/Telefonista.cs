using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_12_2024
{
    public class Telefonista : Funcionario
    {
        public string EstacaoDeTrabalho;

        public Telefonista(string nome, string cpf, double salario, string estacaodetrabalho) : base(nome, cpf, salario)
        {
            this.EstacaoDeTrabalho = estacaodetrabalho;
        }

        public override double getBonificacao()
        {
            return Salario * 0.05;
        }

        public override void Imprimir()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("Estação de Trabalho: " + EstacaoDeTrabalho);
            System.Console.WriteLine("Bonificação: " + getBonificacao());

        }

        public void atenderTelefone()
        {
            System.Console.WriteLine("Atendendo telefone . . .\n");
        }
    }


}