using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_3
{
    public class Caminhao : Veiculo
    {
        public int NumeroDeEixos { get; set; }

        public Caminhao(string placa, string modelo, double valorBaseDiaria, int numeroDeEixos)
            : base(placa, modelo, valorBaseDiaria)
        {
            NumeroDeEixos = numeroDeEixos;
        }

        public override double CalcularDiaria()
        {
            return ValorBaseDiaria + (NumeroDeEixos * 50);
        }
    }
}