using System;

namespace Exercicio_3;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];
        int maior, menor;

        Console.WriteLine("Digite os elementos da matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        maior = matriz[0, 0];
        menor = matriz[0, 0];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (matriz[i, j] > maior)
                    maior = matriz[i, j];
                if (matriz[i, j] < menor)
                    menor = matriz[i, j];
            }
        }

        int soma = maior + menor;

        Console.WriteLine($"\nO maior elemento é: {maior}");
        Console.WriteLine($"O menor elemento é: {menor}");
        Console.WriteLine($"A soma do maior com o menor elemento é: {soma}");
    }
}
