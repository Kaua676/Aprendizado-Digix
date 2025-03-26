using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_13_12_2024
{
    public class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void realizarDeposito(double valor)
        {
            Saldo += valor;
        }

        public void realizarSaque(double valor)
        {
            Saldo -= (valor + 5.00);
        }

        public override string ToString()
        {
            return $"Conta {Numero}\nTitular: {Titular}\nSaldo: $ {Saldo:F2}";
        }
    }
}