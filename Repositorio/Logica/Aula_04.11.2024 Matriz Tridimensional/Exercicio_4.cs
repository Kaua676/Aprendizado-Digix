using System;

namespace Exercicio_3
{
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
            int soma_diagonal_secundaria = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma_diagonal += matriz[i, i];
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma_diagonal_secundaria += matriz[i, (matriz.GetLength(0) - 1) - i];
            }

            Console.WriteLine($"A soma dos elementos da diagonal principal: {soma_diagonal}");
            Console.WriteLine($"A soma dos elementos da diagonal secundária: {soma_diagonal_secundaria}");

        }
    }
}
