using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_12_2024
{

    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public virtual void Consultar()
        {
            Console.WriteLine($"Usuário: {Nome}, CPF: {CPF}");
        }
    }


}