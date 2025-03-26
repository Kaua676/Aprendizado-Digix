using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_03_01_2024
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public Estado Estado { get; set; }
        public string CEP { get; set; }

        public Endereco(string rua, string cidade, Estado estado, string cep)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }

        public Endereco() { }
    }
}