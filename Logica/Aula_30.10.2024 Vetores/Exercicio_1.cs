using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int menor = 0;
            int i;

            Console.WriteLine("Digite 10 números inteiros e positivos:");

            for (i = 1; i <= 10; i++)
            {
                Console.Write($"Número {i}: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Por favor, insira apenas números positivos.");
                    i--;
                    continue;
                }

                if (i == 1)
                {
                    maior = numero;
                    menor = numero;
                    continue;
                }

                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

            Console.WriteLine($"\nO maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
        }
    }
}
