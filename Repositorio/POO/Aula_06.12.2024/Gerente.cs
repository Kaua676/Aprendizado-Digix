using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_12_2024
{
    public class Gerente : Funcionario // Utiliza-se ":" para herdar a classe
    {
        // Atributos globais de Gerente
        public string Setor;

        //Construtor com parâmetros
        public Gerente(string nome, string cpf, double salario, string setor) : base(nome, cpf, salario)
        {
            // O base é utilizado para chamar o construtor da classe pai
            this.Setor = setor;
        }

        // Metodo para calcular salario
        public override double getBonificacao() // Override é utilizado para sobrescrever a função da classe pai
        {
            return Salario * 0.15;
        }

        public override void Imprimir() // Override é utilizado para sobrescrever a função da classe pai
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("Setor: " + Setor);
            System.Console.WriteLine("Bonificação: " + getBonificacao());
        }

        public void gerenciarEquipe()
        {
            System.Console.WriteLine("Gerindo equipe\n");
        }
    }
}