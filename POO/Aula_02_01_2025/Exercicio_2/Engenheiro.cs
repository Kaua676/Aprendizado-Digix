using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public class Engenheiro
    {
        public string Nome { get; set; }
        public int CREA { get; set; }

        public Engenheiro(string nome, int crea)
        {
            Nome = nome;
            CREA = crea;
        }
    }
}