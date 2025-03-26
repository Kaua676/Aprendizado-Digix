using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_03_01_2024
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoFinal { get; set; }
        public string Apelido { get; set; }
        public bool Perecivel { get; set; }
        public DateTime DataValidade { get; set; }

        public double CalcularPrecoFinal()
        {
            return PrecoCusto;
        }
    }
}