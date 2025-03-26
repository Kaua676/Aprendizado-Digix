using System;

namespace Exercicio_4
{
    class Program
    {
        static int CalcularMDC(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return CalcularMDC(b, a % b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultadoMDC = CalcularMDC(num1, num2);
            Console.WriteLine($"O MDC de {num1} e {num2} é: {resultadoMDC}");
        }
    }
}
