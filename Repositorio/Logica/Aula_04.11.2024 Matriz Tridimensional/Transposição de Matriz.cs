using System;

namespace Transposição_de_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3]{
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] transposta = new int[3, 3];

            for (int i = 0; i < transposta.GetLength(0); i++)
            {
                for (int j = 0; j < transposta.GetLength(1); j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
                System.Console.WriteLine();
            }

            for (int i = 0; i < transposta.GetLength(0); i++)
            {
                for (int j = 0; j < transposta.GetLength(1); j++)
                {
                    System.Console.Write(transposta[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
