using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public class Imovel
    {
        public string Endereco { get; set; }
        public double AreaTotal { get; set; }
        public string Responsavel { get; set; }
        public string CREA { get; set; }

        public Imovel(string endereco, double areaTotal, string responsavel, string crea)
        {
            Endereco = endereco;
            AreaTotal = areaTotal;
            Responsavel = responsavel;
            CREA = crea;
        }

        public virtual string DescricaoDoImovel()
        {
            return $"Situado a {Endereco}.\nÁrea total: {AreaTotal}m².\nResponsável: {Responsavel}. CREA {CREA}.";
        }
    }
}