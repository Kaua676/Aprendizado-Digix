using System;

namespace Exercicio_4
{
    class Program
    {
        public static int SomaDiagonais(int[,] matriz)
        {
            int soma_diagonal = 0;
            int soma_diagonal_secundaria = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma_diagonal += matriz[i, i];
                soma_diagonal_secundaria += matriz[i, (matriz.GetLength(0) - 1) - i];
            }

            Console.WriteLine("Soma da diagonal principal: " + soma_diagonal);
            Console.WriteLine("Soma da diagonal secundária: " + soma_diagonal_secundaria);

            return soma_diagonal + soma_diagonal_secundaria;
        }

        static void Main(string[] args)
        {
            int[,] matriz = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 18, 12 },
                { 13, 14, 15, 16 }
            };

            int somaTotal = SomaDiagonais(matriz);
            Console.WriteLine("Soma total das diagonais: " + somaTotal);
        }
    }
}
