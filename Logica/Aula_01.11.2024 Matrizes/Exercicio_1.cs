using System;

namespace Exercicio_1;

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

        // Exibe os números na ordem direta
        Console.WriteLine("\nNúmeros na ordem direta:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(numeros[i] + " ");
        }

        // Exibe os números na ordem inversa
        Console.WriteLine("\n\nNúmeros na ordem inversa:");
        for (int i = 9; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}
