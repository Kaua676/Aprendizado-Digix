using System;

namespace Exercicio_6
{
    class Program
    {
        static int SomaVetor(int[] vetor, int i)
        {
            if (i == vetor.Length)
            {
                return 0;
            }

            return vetor[i] + SomaVetor(vetor, i + 1);
        }

        static (int, double) SomaMediaVetor(int[] vetor, int index, int tamanho)
        {
            if (index < 0)
                return (0, 0);

            (int somaParcial, double _) = SomaMediaVetor(vetor, index - 1, tamanho);
            int somaTotal = somaParcial + vetor[index];

            double media = (double)somaTotal / tamanho;

            return (somaTotal, media);
        }

        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3,
                            4, 5, 6,
                            7, 8, 9};

            int media = SomaVetor(vetor, 0);

            Console.WriteLine($"A media dos valores do vetor é: {media / vetor.Length}");

            (int soma, double media_) = SomaMediaVetor(vetor, vetor.Length - 1, vetor.Length);

            Console.WriteLine($"A media dos valores do vetor é: {media_}");
        }


    }
}

