using System;

namespace Exercicio_4;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
            };
        int soma_diagonal = 0;

        Console.WriteLine("Digite os elementos da matriz 4x4:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma_diagonal += matriz[i, i];
        }

        Console.WriteLine($"A soma dos elementos da diagonal principal: {soma_diagonal}");
    }
}
