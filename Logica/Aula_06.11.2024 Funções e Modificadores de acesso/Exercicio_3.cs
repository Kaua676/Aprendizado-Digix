using System;

namespace Exercicio_3
{
    class Program
    {
        static bool VetorPalindromo(int[] vetor)
        {
            int n = vetor.Length;
            int[] numerosInversos = new int[n];

            Console.WriteLine("Vetor original:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vetor[i] + " ");
                numerosInversos[n - 1 - i] = vetor[i];
            }

            Console.WriteLine("\nVetor inverso:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numerosInversos[i] + " ");
            }
            Console.WriteLine();

            
            for (int i = 0; i < n / 2; i++)
            {
                if (vetor[i] != numerosInversos[i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            Random random = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(100); 
            }

            bool resultado = VetorPalindromo(vetor);

            if (resultado)
            {
                Console.WriteLine("\nO vetor é um palíndromo.");
            }
            else
            {
                Console.WriteLine("\nO vetor não é um palíndromo.");
            }
        }
    }
}
