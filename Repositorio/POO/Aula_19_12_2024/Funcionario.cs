using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_12_2024
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; }

        public Funcionario(string nome, string cpf, string cargo) : base(nome, cpf)
        {
            Cargo = cargo;
        }

        public void RealizarEmprestimo(Livro livro, Leitor leitor)
        {
            Console.WriteLine($"{Nome} (Funcionário) realizou o empréstimo de '{livro.Titulo}' para {leitor.Nome}");
        }
    }
}
