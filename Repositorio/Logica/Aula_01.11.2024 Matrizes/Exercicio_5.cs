using System;

namespace Exercicio_5;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrizA = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

        int[,] matrizB = {
                {50, 60, 70, 80},
                {90, 100, 110, 120},
                {130, 140, 150, 160},
                {170, 180, 190, 200}
            };

        int[,] soma_matriz = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                soma_matriz[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        for (int i = 0; i < 4; i++){
            for (int j = 0; j < 4; j++){
                System.Console.Write(soma_matriz[i, j] + "\t");
            }
             System.Console.WriteLine();
        }
    }
}