using System;

namespace Exercicio_1
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
            int[] vetor = {};
            System.Console.WriteLine("Digite o tamanho do vetor: ");
            int tam = int.Parse(Console.ReadLine());

            for (int i = 0; i < tam; i++)
            {
                System.Console.WriteLine("Digite um numero: ");
                int num = int.Parse(Console.ReadLine());
                Array.Resize(ref vetor, vetor.Length + 1);
                vetor[i] = num;
            }

            Ordernar(vetor);
            System.Console.WriteLine("Vetor ordenado: ");
            Imprimir(vetor);
        }
    }
}