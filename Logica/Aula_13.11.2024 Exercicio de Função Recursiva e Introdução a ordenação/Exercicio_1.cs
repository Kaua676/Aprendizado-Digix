using System;

namespace Exercicio_1
{
    class Program
    {
        static int soma(int n)
        {
            if (n <= 0)
                return 0;
            else
                return n + soma(n - 1);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número para somar: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"O reesultado da sua soma é: {soma(n)}");
        }
    }
}