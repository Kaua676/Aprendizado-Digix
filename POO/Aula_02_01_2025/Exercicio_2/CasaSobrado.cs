using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public class CasaSobrado : Casa
    {
        public int NumAndares { get; set; }

        public CasaSobrado(int numAndares, bool condominio, float metragemTotal, string endereco, Engenheiro responsavel)
            : base(condominio, metragemTotal, endereco, responsavel)
        {
            NumAndares = numAndares;
        }

        public override string DescricaoDoImovel()
        {
            return base.DescricaoDoImovel() + $" Número de andares: {NumAndares}.";
        }
    }
}