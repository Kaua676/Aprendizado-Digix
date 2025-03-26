using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_1
{
    public class HomoSapiens : Animalia
    {
        public HomoSapiens()
            : base("Chordata", "Mammalia", "Primata", "Hominidae", "Homo", "Homo sapiens") { }

        public override string ObterDescricao()
        {
            return $"Reino: {Reino}\n" +
                   $"Filo: {Filo}\n" +
                   $"Classe: {Classe}\n" +
                   $"Ordem: {Ordem}\n" +
                   $"Família: {Familia}\n" +
                   $"Gênero: {Genero}\n" +
                   $"Espécie: {Especie}";
        }
    }
}