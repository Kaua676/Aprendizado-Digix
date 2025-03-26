using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public class UnidadeResidencial
    {
        public float MetragemUnidade { get; set; }
        public int NumQuartos { get; set; }
        public int NumBanheiros { get; set; }
        public Pessoa Proprietario { get; set; }

        public UnidadeResidencial(float metragemUnidade, int numQuartos, int numBanheiros, Pessoa proprietario)
        {
            MetragemUnidade = metragemUnidade;
            NumQuartos = numQuartos;
            NumBanheiros = numBanheiros;
            Proprietario = proprietario;
        }

        public string GetProprietario()
        {
            Proprietario = Proprietario;
            return Proprietario.Nome;
        }

        public void SetProprietario(Pessoa proprietario)
        {
            Proprietario = proprietario;
        }
    }
}