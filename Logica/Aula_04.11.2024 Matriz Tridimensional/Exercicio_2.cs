using System;

namespace Exercicio_2
{
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

            System.Console.WriteLine("A soma dos elementos da primeira linha da matriz A é: " + (matrizA[0, 0] + matrizA[0, 1] + matrizA[0, 2] + matrizA[0, 3]));
            System.Console.WriteLine("A soma dos elementos da segunda linha da matriz A é: " + (matrizA[1, 0] + matrizA[1, 1] + matrizA[1, 2] + matrizA[1, 3]));
            System.Console.WriteLine("A soma dos elementos da terceira linha da matriz A é: " + (matrizA[2, 0] + matrizA[2, 1] + matrizA[2, 2] + matrizA[2, 3]));
            System.Console.WriteLine("A soma dos elementos da quarta linha da matriz A é: " + (matrizA[3, 0] + matrizA[3, 1] + matrizA[3, 2] + matrizA[3, 3]));

        }
    }
}
