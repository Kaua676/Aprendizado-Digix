using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo a matriz original
            int[,] matriz = new int[3, 3]{
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Matriz para armazenar o resultado da rotação
            int[,] rotacionada = new int[3, 3];

            // Rotacionar a matriz em 90 graus para a direita
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rotacionada[j, 2 - i] = matriz[i, j];
                }
            }

            // Imprimindo a matriz resultante após a rotação
            Console.WriteLine("Matriz rotacionada em 90 graus:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(rotacionada[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
