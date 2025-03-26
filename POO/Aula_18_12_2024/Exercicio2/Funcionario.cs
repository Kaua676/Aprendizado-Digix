using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio2
{
    public class Funcionario
    {
        public string Nome { get; }
        public DateTime Nascimento { get; }
        public string Cpf { get; }
        public Endereco Endereco { get; set; }

        public Funcionario(string nome, DateTime nascimento, string cpf, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
            Endereco = endereco;
        }
    }

}