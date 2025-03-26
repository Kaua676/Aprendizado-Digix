using System;

namespace InsertionSort
{
    class Program
    {
        static void Ordernar(int[] vetor)
        {
            int aux, j;

            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;

                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j + 1] = aux;

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