using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_10_01_2025
{
    public struct ContaBancariaStruct
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancariaStruct(string numero, string titular, decimal saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (this.Saldo < valor)
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
            this.Saldo -= valor;
        }

        public void AlterarSaldo(decimal valor)
        {
            this = new ContaBancariaStruct(this.Numero, this.Titular, valor + this.Saldo);
            System.Console.WriteLine("Saldo alterado com sucesso: " + this.Saldo);
        }

        public override string ToString()
        {
            return $"Conta: {this.Numero}, Titular: {this.Titular}, Saldo: {this.Saldo}";
        }
    }

    public class ContaBancariaClass
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancariaClass(string numero, string titular, decimal saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (this.Saldo < valor)
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
            this.Saldo -= valor;
        }

        public void AlterarSaldo(decimal valor)
        {
            this.Saldo += valor;
            System.Console.WriteLine("Saldo alterado com sucesso: " + this.Saldo);
        }

        public override string ToString()
        {
            return $"Conta: {this.Numero}, Titular: {this.Titular}, Saldo: {this.Saldo}";
        }
    }

    class Exe
    {
        static void Main(string[] args)
        {
            ContaBancariaStruct conta1 = new ContaBancariaStruct("123", "Kauã", 1000.00m);
            ContaBancariaClass conta2 = new ContaBancariaClass("456", "Maria", 2000.00m);

            System.Console.WriteLine(conta1);
            System.Console.WriteLine(conta2);

            conta1.Depositar(500.00m);
            conta2.Depositar(500.00m);

            System.Console.WriteLine(conta1);
            System.Console.WriteLine(conta2);

            conta1.Sacar(1000.00m);
            conta2.Sacar(1000.00m);

            System.Console.WriteLine(conta1);
            System.Console.WriteLine(conta2);

            conta1.AlterarSaldo(1000.00m);
            conta2.AlterarSaldo(1000.00m);
        }
    }
}