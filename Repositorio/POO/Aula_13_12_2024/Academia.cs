using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_13_12_2024
{
    public class Academia
    {
        public string Nome {get; set;}

        private double Mensalidade {get; set;} // Classe superior não terá acesso

        public Academia(string nome, double mensalidade)
        {
            Nome = nome;
            Mensalidade = mensalidade;
        }
    }
}