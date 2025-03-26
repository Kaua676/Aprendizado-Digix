using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_01_2025
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NumeroCartao { get; set; }
        public string Senha { get; set; }
        public List<Conta> Contas { get; set; } = new List<Conta>();

        public Cliente(string nome, string endereco, DateTime dataNascimento, string numeroCartao, string senha)
        {
            Nome = nome;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            NumeroCartao = numeroCartao;
            Senha = senha;
        }

        public void AdicionarConta(Conta conta)
        {
            Contas.Add(conta);
        } 

        public bool VerificarSenha(string senhaInserida)
        {
            if (senhaInserida == Senha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}