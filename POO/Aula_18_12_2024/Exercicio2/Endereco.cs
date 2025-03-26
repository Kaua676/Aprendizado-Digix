using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio2
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public Cidade Cidade { get; set; }

        public Endereco(string rua, int numero, string bairro, string cep, Cidade cidade)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
        }

        public override string ToString()
        {
            return $"{Rua}, {Numero}, {Bairro}, {Cidade.Nome} - {Cidade.Estado.Sigla}, {Cep}";
        }
    }

}