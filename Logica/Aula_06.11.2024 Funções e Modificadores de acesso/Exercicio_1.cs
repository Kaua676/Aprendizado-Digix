using System;

namespace Exercicio_1
{
    class Program
    {
        public delegate double CalcularMedia(int[] valores);

        static double Media(int[] valores)
        {
            int soma = 0;
            foreach (var valor in valores)
            {
                soma += valor;
            }
            return (double)soma / valores.Length;
        }

        static void Main(string[] args)
        {
            int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double media = Media(valores);
            Console.WriteLine("A media dos elementos do vetor é: " + media);
        }
    }
}