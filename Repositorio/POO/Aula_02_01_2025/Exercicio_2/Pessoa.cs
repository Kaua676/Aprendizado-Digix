using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}