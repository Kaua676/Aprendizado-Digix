using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio2
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, DateTime nascimento, string cpf, Endereco endereco) : base(nome, nascimento, cpf, endereco)
        {
        }

        public float getSalario()
        {
            return 20000;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Nascimento: {Nascimento:dd/MM/yyyy}, CPF: {Cpf}, Endereço: {Endereco}";
        }
    }
}