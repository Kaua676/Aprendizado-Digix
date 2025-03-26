using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public abstract class Empregado
    {
        public string Nome;
        public string sobreNome;
        public string CPF;

        public Empregado(string nome, string sobrenome, string cpf)
        {
            Nome = nome;
            sobreNome = sobrenome;
            CPF = cpf;
        }

        public abstract double Vencimento();

        public virtual void imprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Sobrenome:" + sobreNome);
            System.Console.WriteLine("CPF: " + CPF);
        }
    }
}