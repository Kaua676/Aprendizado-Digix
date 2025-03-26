using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_3
{
    public class Utilitario : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public Utilitario(string placa, string modelo, double valorBaseDiaria, double capacidadeCarga)
            : base(placa, modelo, valorBaseDiaria)
        {
            CapacidadeCarga = capacidadeCarga;
        }

        public override double CalcularDiaria()
        {
            if (CapacidadeCarga <= 1000)
            {
                return ValorBaseDiaria;
            }
            else if (CapacidadeCarga <= 2000)
            {
                return ValorBaseDiaria * 1.2;
            }
            else
            {
                return ValorBaseDiaria * 1.5;
            }
        }
    }
}