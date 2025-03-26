using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_01_2025
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numeroConta, double saldo, Cliente proprietario) : base(proprietario, numeroConta, saldo) { }

        public override void Sacar(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser maior que zero.");
            if (Saldo < valor)
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
            Saldo -= valor;
            AdicionarTransacao(TipoTransacao.Saque, valor);
        }
    }
}