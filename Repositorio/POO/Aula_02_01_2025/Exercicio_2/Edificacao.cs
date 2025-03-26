using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public abstract class Edificacao
    {
        public float MetragemTotal { get; set; }
        public string Endereco { get; set; }
        public Engenheiro Responsavel { get; set; }
        public List<UnidadeResidencial> Unidades { get; set; }

        public Edificacao(float metragemTotal, string endereco, Engenheiro responsavel)
        {
            MetragemTotal = metragemTotal;
            Endereco = endereco;
            Responsavel = responsavel;
            Unidades = new List<UnidadeResidencial>();
        }

        public List<UnidadeResidencial> GetUnidades() => Unidades;

        public bool CadastrarUnidade(UnidadeResidencial novaUnidade)
        {
            Unidades.Add(novaUnidade);
            return true;
        }

        public abstract string DescricaoDoImovel();
    }
}