using System;
using System.Globalization;

namespace Exercicio_de_Fixacao
{
    class Exercicio_de_Fixacao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite seu último nome, idade e altura (mesma linha): ");
            string[] valores = Console.ReadLine().Split(' ');
            string ultimonome = valores[0];
            int idade = int.Parse(valores[1]);
            double altura = double.Parse(valores[2]);

            System.Console.WriteLine("Seu nome é: " +nome);
            System.Console.WriteLine($"Voce tem {quartos} quartos na sua casa");
            System.Console.WriteLine("O valor do seu produto é:" + preco.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Seu ultimo nome é: " +ultimonome);
            System.Console.WriteLine("Sua idade é: " +idade);
            System.Console.WriteLine("Sua altura é: " +altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}