using System;

namespace Exercicio_5
{
    class Program
    {
        static int SomarVetor(int[] vetor, int i)
        {
            if (i == vetor.Length)
            {
                return 0;
            }

            return vetor[i] + SomarVetor(vetor, i + 1);
        }

        static void Main(string[] args)
        {
            int[] vetor = {1, 2, 3,
                       4, 5, 6,
                       7, 8, 9};

            int resultado = SomarVetor(vetor, 0);

            Console.WriteLine("A soma dos valores do vetor é: " + resultado);
        }
    }
}
