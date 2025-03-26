using System;

namespace Exercicio_Vethor
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = Random.Shared.Next(0, 100);
            }

            int maior = vetor[0];
            int menor = vetor[0];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{vetor[i]} ");
            }

            for (int i = 1; i < 10; i++)
            {

                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
            Console.WriteLine($"\nO maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
        }
    }
}
