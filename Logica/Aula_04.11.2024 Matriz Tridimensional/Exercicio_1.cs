using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Digite um numero: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += vetor[i];
            }

            double media = (double)soma / 10;
            System.Console.WriteLine("A media dos elementos do vetor é: " + media);
        }
    }
}
