using System;

namespace Exercicio_4
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

                while (j >= 0 && vetor[j] < aux)
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
            int[] vetor = { };
            Console.WriteLine("Digite o tamanho do vetor: ");
            int tam = int.Parse(Console.ReadLine());

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Digite um numero: ");
                int num = int.Parse(Console.ReadLine());
                Array.Resize(ref vetor, vetor.Length + 1);
                vetor[i] = num;
            }

            Ordernar(vetor);
            System.Console.WriteLine("Vetor ordenado em ordem decrescente: ");
            Imprimir(vetor);

        }
    }
}