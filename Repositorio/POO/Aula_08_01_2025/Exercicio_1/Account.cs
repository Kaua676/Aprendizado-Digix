using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_08_01_2025.Exercicio_1
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (withdrawLimit <= 0)
            {
                throw new DomainException("Limite de saque negativo!");
            }
            if (balance <= 0)
            {
                throw new DomainException("Saldo negativo!");
            }
            Number = number;
            Holder = holder;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Limite de saque excedido!");
            }
            if (amount < Balance)
            {
                throw new DomainException("Saldo insuficiente!");
            }
            Balance -= amount;
        }
    }
}