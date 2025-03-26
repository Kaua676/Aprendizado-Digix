using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_3
{
    public abstract class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public double ValorBaseDiaria { get; set; }

        public Veiculo(string placa, string modelo, double valorBaseDiaria)
        {
            Placa = placa;
            Modelo = modelo;
            ValorBaseDiaria = valorBaseDiaria;
        }

        public abstract double CalcularDiaria();
    }
}