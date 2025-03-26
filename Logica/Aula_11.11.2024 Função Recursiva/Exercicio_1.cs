using System;

namespace Funcao_Recursiva
{
    class Program
    {
        static int Pares(int[] vetor, int n)
        {
            if (n == 0)
                return 0;
            else if (vetor[n - 1] % 2 == 0)
                return vetor[n - 1] + Pares(vetor, n - 1);
            else
                return Pares(vetor, n - 1);
        }

        static int Impares(int[] vetor, int n)
        {
            if (n == 0)
                return 0;
            else if (vetor[n - 1] % 2 != 0)
                return vetor[n - 1] + Impares(vetor, n - 1);
            else
                return Impares(vetor, n - 1);
        }
       
        static void Main(string[] args)
        {
            //Imprime os numeros pares do vetor
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            System.Console.WriteLine(Pares(vetor, 10));
            System.Console.WriteLine(Impares(vetor, 10));
        }
    }
}
