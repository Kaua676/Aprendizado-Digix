using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_12_2024
{
    public class Leitor : Usuario
    {
        public Leitor(string nome, string cpf) : base(nome, cpf) { }

        public void PegarEmprestado(Livro livro)
        {
            Console.WriteLine($"{Nome} pegou o livro emprestado: {livro.Titulo}");
        }
    }
}
