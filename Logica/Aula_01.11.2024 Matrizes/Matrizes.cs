using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 2]; //2 linhas e 2 colunas
            int[,] matriz2 = new int[2, 2]
            {
                { 1,2}, // Linha 0 tem 1 e 2, Linha 1 tem 3 e 4
                { 3,4}  // Coluna 0 tem 1 e 3, Coluna 1 tem 2 e 4
            };

            //Acessando a Matriz
            System.Console.WriteLine(matriz2[0, 0]); //1
            System.Console.WriteLine(matriz2[0, 1]); //2

            //Percorrendo a Matriz
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz2[i, j]);
                }
            }

            //Somando os elementos da matriz
            int[,] matrizA = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int [,] matrizB = {
                {9, 8, 7 },
                {6, 5, 4},
                {3, 2, 1}
            };
            int [,] matrizC = new int[3, 3];
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            //Exibindo a matriz C
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    System.Console.WriteLine(matrizC[i, j]);
                }
            }
        }
    }
}