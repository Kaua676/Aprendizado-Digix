using System;

namespace Exercicio_2
{
    class Program
    {
        public delegate void SomaMatriz(int[,] matriz);

        static void Matriz(int[,] matriz)
        {

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int soma = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];


                }
                System.Console.WriteLine($"A soma dos elementos da linha {i + 1} é: {soma}");
            }
        }

        static void Main(string[] args)
        {
            int[,] matriz = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            SomaMatriz mat = Matriz;

            mat(matriz);
        }
    }
}