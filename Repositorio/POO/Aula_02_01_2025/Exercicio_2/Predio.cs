using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public class Predio : Edificacao
    {
        private string Nome { get; set; }
        private int NumAndares { get; set; }
        private int ApPorAndar { get; set; }

        public Predio(string nome, int numAndares, int apPorAndar, float metragemTotal, string endereco, Engenheiro responsavel)
            : base(metragemTotal, endereco, responsavel)
        {
            Nome = nome;
            NumAndares = numAndares;
            ApPorAndar = apPorAndar;
        }

        public override string DescricaoDoImovel()
        {
            string descricao = $"Prédio {Nome}.\n" +
                               $"Situado à {Endereco}.\n" +
                               $"Área total: {MetragemTotal} metros quadrados.\n" +
                               $"Responsável: Eng. {Responsavel.Nome}. CREA {Responsavel.Nome}.\n" +
                               $"Número de andares: {NumAndares}.\n" +
                               $"Número de apartamentos por andar: {ApPorAndar}.\n";

            if (Unidades != null && Unidades.Count > 0)
            {
                for (int i = 0; i < Unidades.Count; i++)
                {
                    var unidade = Unidades[i];
                    descricao += $"Unidade {i + 1}\n" +
                                 $"Propriedade de {unidade.GetProprietario()}.\n" +
                                 $"Possui {unidade.MetragemUnidade} metros quadrados, " +
                                 $"{unidade.NumQuartos} quartos, {unidade.NumBanheiros} banheiros.\n";
                }
            }
            return descricao;
        }
    }
}