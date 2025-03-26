using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aula_13_12_2024
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Produto p = new Produto("Bomba Atomica", 10000);
            // //Vou alterar o nome do produto
            // // p.setNome("Bomba Nuclear");

            // //Propriedade
            // p.Nome = "Bomba Nuclear";

            // p.Preco = (200000);

            // p.setQuantidade(10);

            // System.Console.WriteLine("Nome: " + p.Nome + "Preço: " + p.Preco + "Quantidade: " + p.getQuantidade());
            // //Imprimir pelo TOString
            // System.Console.WriteLine(p.ToString());

            // //Algumas funções para validar seus tipos e propriedades
            // // A classe type representa o metadado de uma classe em tempo de execução 
            // Type t = typeof(Produto); // Vai retornar o tipo de classe
            // System.Console.WriteLine(t.Name); // Vai retornar o nome da classe

            // // Todas as suas propriedades
            // System.Console.WriteLine("Propriedades: ");
            // foreach (PropertyInfo prop in t.GetProperties())
            // {
            //     System.Console.WriteLine(prop.Name);
            // }

            ContaBancaria conta;
            System.Console.WriteLine("Insira o numero da sua conta: ");
            int numero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o nome do titular: ");
            string titular = Console.ReadLine();

            System.Console.WriteLine("Deseja iniciar um depósito? (s/n)");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                System.Console.WriteLine("Insira o valor de deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            System.Console.WriteLine("\nDados da conta: \n");
            System.Console.WriteLine(conta);

            System.Console.WriteLine("\nInsira o valor do deposito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.realizarDeposito(valor);
            System.Console.WriteLine("\nDados atualizados após o deposito:");
            System.Console.WriteLine(conta);

            System.Console.WriteLine("\nInsira o valor de saque:  (lembrando que possui uma taxa fixa de R$5,00)");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.realizarSaque(saque);
            System.Console.WriteLine("\nDados atualizados após o saque:");
            System.Console.WriteLine(conta);
        }
    }
}