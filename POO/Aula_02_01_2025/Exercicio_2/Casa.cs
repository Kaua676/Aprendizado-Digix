using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public class Casa : Edificacao
    {
        public bool Condominio { get; set; }

        public Casa(bool condominio, float metragemTotal, string endereco, Engenheiro responsavel)
            : base(metragemTotal, endereco, responsavel)
        {
            Condominio = condominio;
        }

        public override string DescricaoDoImovel()
        {
            return $"Casa{(Condominio ? " em condomínio." : ".")}";
        }
    }
}