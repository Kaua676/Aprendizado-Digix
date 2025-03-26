using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio2
{
    public class Estado
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public override string ToString()
        {
            return $"{Nome} ({Sigla})";
        }
    }

}