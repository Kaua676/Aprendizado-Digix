using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_3
{
    // Carro
    public class Carro : Veiculo
    {
        public string Categoria { get; set; } // A, B ou C

        public Carro(string placa, string modelo, double valorBaseDiaria, string categoria)
            : base(placa, modelo, valorBaseDiaria)
        {
            Categoria = categoria.ToUpper();
        }

        public override double CalcularDiaria()
        {
            if (Categoria == "A")
            {
                return ValorBaseDiaria;
            }

            if (Categoria == "B")
            {
                return ValorBaseDiaria * 1.2;
            }

            if (Categoria == "C")
            {
                return ValorBaseDiaria * 1.5;
            }

            return 0;
        }
    }
}
