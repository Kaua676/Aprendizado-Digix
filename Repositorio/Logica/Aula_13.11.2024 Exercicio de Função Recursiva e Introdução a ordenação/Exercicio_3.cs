using System;

namespace Exercicio_3
{
    class Program
    {
        static int potencia(int x, int n)
        {    
            if (n == 0)
                return 1;
            else
                return x * potencia(x, n - 1);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor da base da potencia: ");
            int x = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Agora digite o valor do expoente: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"O reesultado da sua potencia é: {potencia(x, n)}");
        }
    }
}