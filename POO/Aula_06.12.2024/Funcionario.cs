using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_12_2024
{
    public class Funcionario
    {
        //Atribuição globais de funcionario
        public string Nome;
        public string CPF;
        public double Salario;

        //Construtor com parâmetros
        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Salario = salario;
        }

        //Metodo para calcular Salario
        public virtual double getBonificacao() //Virtual permite que a classe filha possa sobrescrever o metodo
        {
            return Salario * 0.10;
        }

        public virtual void Imprimir()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("Bonificação: " + getBonificacao());
        }
    }
}