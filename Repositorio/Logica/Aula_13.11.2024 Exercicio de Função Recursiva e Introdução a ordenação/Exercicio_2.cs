using System;

namespace Exercicio_2
{
    class Program
    {
        static int produto(int n)
        {
            if (n <= 0)
                return 1;
            else
                return n * produto(n - 1);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número para multiplicar: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"O reesultado da sua produto é: {produto(n)}");
        }
    }
}