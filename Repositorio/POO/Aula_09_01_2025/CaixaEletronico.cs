using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_01_2025
{
    public class CaixaEletronico
    {
        public string Localizacao { get; set; }
        public Banco GerenciadoPor { get; set; }

        public CaixaEletronico(string localizacao, Banco gerenciadoPor)
        {
            Localizacao = localizacao;
            GerenciadoPor = gerenciadoPor;
        }

        public void ProcessarTransacao(Conta conta, TipoTransacao tipo, double valor)
        {
            if (tipo == TipoTransacao.Deposito)
                conta.Depositar(valor);
            else if (tipo == TipoTransacao.Saque)
                conta.Sacar(valor);
            else
                throw new ArgumentException("Tipo de transação inválido.");
        }
    }
}