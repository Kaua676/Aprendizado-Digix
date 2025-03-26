using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue; // Inicializa com o menor valor possível
            int menor = int.MaxValue; // Inicializa com o maior valor possível
            int numero;

            Console.WriteLine("Digite números inteiros e positivos (digite -1 para sair):");

            while (true)
            {
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == -1)
                {
                    break; // Encerra o loop se o número for -1
                }

                if (numero < 0)
                {
                    Console.WriteLine("Por favor, insira apenas números positivos.");
                    continue; // Volta para o início do loop se o número for negativo
                }

                // Atualiza o maior e o menor número
                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

            // Verifica se algum número válido foi inserido
            if (maior == int.MinValue && menor == int.MaxValue)
            {
                Console.WriteLine("Nenhum número válido foi inserido.");
            }
            else
            {
                Console.WriteLine($"\nO maior número é: {maior}");
                Console.WriteLine($"O menor número é: {menor}");
            }
        }
    }
}