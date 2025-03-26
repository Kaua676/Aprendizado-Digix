using System;

namespace SelectionSortDecrescente
{
    public class Program
    {
        static void Ordernar(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] > vetor[menor])
                    {
                        menor = j;
                    }
                }
                aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
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
            System.Console.WriteLine("Vetor ordenado de forma decrescente: ");
            Imprimir(vetor);
        }
    }
}