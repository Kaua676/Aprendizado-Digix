using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_08_01_2025.Exercicio_1;

namespace Aula_08_01_2025.Exercicio_1
{
    public class Executar
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Digite o numero da conta: ");
            int number = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o titular da conta: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Digite o saldo da conta: ");
            double balance = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o limite de saque da conta: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, name, balance, withdrawLimit);

            System.Console.WriteLine("Digite o valor do saque: ");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);

        }
    }
}