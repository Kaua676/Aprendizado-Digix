using System;

namespace Exercicio_Vethor
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ler um vetor com 10 inteiros e mostrar os valores da ordem direta e inversa em que foram lidos.
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                // Console.Write("Digite um numero: ");
                // vetor[i] = int.Parse(Console.ReadLine());
                vetor[i] = Random.Shared.Next(0, 100);
            }

            System.Console.WriteLine("Ordem direta:");
            //Ordem direta
            for (int i = 0; i < 10; i++)
            {

                Console.Write($"{vetor[i]} ");
            }

            System.Console.WriteLine("\nOrdem inversa:");
            //Ordem inversa
            for (int i = 9; i >= 0; i--)
            {

                Console.Write($"{vetor[i]} ");
            }
        }
    }
}