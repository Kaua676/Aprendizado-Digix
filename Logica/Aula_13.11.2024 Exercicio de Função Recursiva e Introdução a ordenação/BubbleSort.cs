using System;

namespace BubbleSort
{
    class Program
    {
        //Função para ordenar em ordem crescente com Bubble Sort
        static void Ordernar(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
        }

        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] vetor = { 19, 41, 28, 10, 9, 7, 11, 1, 2 };
            System.Console.WriteLine("Vetor desordenado: ");
            Imprimir(vetor);

            Ordernar(vetor);
            System.Console.WriteLine("Vetor ordenado: ");
            Imprimir(vetor);
        }
    }
}