using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_03_01_2024
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int CNPJ { get; set; }
        public bool Recorrente { get; set; }
        public double Desconto { get; set; }

        public double CalcularDesconto(double valor)
        {
            if (Recorrente)
            {
                return valor * Desconto;
            }
            return 0;
        }
    }
}