using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_3
{
    class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string placa, string modelo, double valorBaseDiaria, int cilindrada = 125)
            : base(placa, modelo, valorBaseDiaria)
        {
            Cilindrada = cilindrada;
        }

        public override double CalcularDiaria()
        {
            return ValorBaseDiaria + (Cilindrada > 125 ? (Cilindrada - 125) * 0.5 : 0);
        }
    }
}