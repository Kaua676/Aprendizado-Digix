using System;

namespace Exercicio_2
{
    class Program
    {
        static void Ordernar(int[] vetor)
        {
            int aux;
            bool trocado;
            int iteracoes = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                trocado = false;

                for (int j = 0; j < vetor.Length - 1 - i; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        // Troca os elementos
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;

                        trocado = true;

                        iteracoes++;
                    }
                }

                if (!trocado)
                {
                    break;
                }
            }

            // Imprimir o número de iterações realizadas
            Console.WriteLine("Número de iterações realizadas: " + iteracoes);
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
            Console.WriteLine("Vetor ordenado: ");
            Imprimir(vetor);
        }
    }
}
