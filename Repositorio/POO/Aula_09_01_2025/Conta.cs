using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_01_2025
{
    public abstract class Conta
    {
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
        public Cliente proprietario { get; set; }
        public List<Transacao> Transacoes { get; set; } = new List<Transacao>();

        public Conta(Cliente proprietario, int numeroConta, double saldo)
        {
            this.proprietario = proprietario;
            this.NumeroConta = numeroConta;
            this.Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Saque inválido. Saldo insuficiente ou valor maior que o limite");
            Saldo += valor;
            AdicionarTransacao(TipoTransacao.Deposito, valor);
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser maior que zero.");
            if (Saldo < valor)
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
            Saldo -= valor;
            AdicionarTransacao(TipoTransacao.Saque, valor);
        }

        public void AdicionarTransacao(TipoTransacao tipo, double valor)
        {
            Transacoes.Add(new Transacao
            {
                IdTransacao = Guid.NewGuid().ToString(),
                Data = DateTime.Now,
                Tipo = tipo,
                Valor = valor,
                SaldoPosterior = Saldo
            });
        }

        public List<Transacao> ObterHistoricoTransacoes()
        {
            return Transacoes;
        }
    }
}