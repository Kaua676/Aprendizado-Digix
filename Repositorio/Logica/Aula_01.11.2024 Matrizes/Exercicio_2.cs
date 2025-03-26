using System;

namespace Exercicio_2;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];

        // Lê os números e armazena no vetor
        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Inicializa o maior e o menor com o primeiro elemento do vetor
        int maior = numeros[0];
        int menor = numeros[0];

        // Percorre o vetor para encontrar o maior e o menor
        for (int i = 1; i < 10; i++)
        {
            if (numeros[i] > maior)
                maior = numeros[i];

            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine($"\nO maior elemento é: {maior}");
        Console.WriteLine($"O menor elemento é: {menor}");
    }
}
