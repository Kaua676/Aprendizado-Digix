using System;

namespace Funcao_Recursiva
{
    class Program
    {
        static double Fatorial(double n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fatorial(n - 1);
        }

        //Fibonacci
        static int Fibonacci(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return Fibonacci(num - 1) + Fibonacci(num - 2);
        }

        //Fatorial com for
        static double Fatorial(double n)
        {
            double fatorial = 1;
            for(double i = 1; i <= n; i++)
                fatorial = i;
            return fatorial;
        }

        //Fibonacci com for
        static int Fibonacci(int num)
        {
            int a = 0, b = 1, c = 1;
            for(int i = 2; i <= num; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número para calcular seu fatorial: ");
            double n = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"O fatorial de {n} é: {Fatorial(n)}");

            System.Console.WriteLine("Digite um número para calcular seu Fibonacci: ");
            int num = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"O Fibonacci de {num} é: {Fibonacci(num)}");
        }
    }
}
