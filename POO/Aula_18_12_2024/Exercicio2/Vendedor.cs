using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio2
{
    public class Vendedor : Funcionario
    {
        public EquipeVenda Equipe { get; set; }

        public Vendedor(EquipeVenda equipe, string nome, DateTime nascimento, string cpf, Endereco endereco)
            : base(nome, nascimento, cpf, endereco)
        {
            Equipe = equipe;
        }

        public float getSalario()
        {
            return 5000;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Nascimento: {Nascimento:dd/MM/yyyy}, CPF: {Cpf}, Endereço: {Endereco}, Equipe: {Equipe}";
        }
    }

}