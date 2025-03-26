using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio2
{
    public class Cidade
    {
        public string Nome { get; set; }
        public Estado Estado { get; set; }

        public Cidade(string nome, Estado estado)
        {
            Estado = estado;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"{Nome} {Estado}";
        }
    }
}