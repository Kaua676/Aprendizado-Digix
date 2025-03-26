using System;

namespace Exercicio_5
{
    class Program
    {
        public static int[,] RotacaoMatriz(int[,] matriz)
        {
            int[,] rotacionada = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rotacionada[j, 2 - i] = matriz[i, j];
                }
            }

            Console.WriteLine("Matriz rotacionada:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(rotacionada[i, j] + " ");
                }
                Console.WriteLine();
            }

            return rotacionada;
        }

        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3]{
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] rotacionada = RotacaoMatriz(matriz);
        }
    }
}
