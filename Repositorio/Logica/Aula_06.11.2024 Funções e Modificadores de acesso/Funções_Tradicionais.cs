using System;

namespace Funções
{
    class Program
    {
        //Função estática que recebe dois valores e retorna a soma
        static int soma(int a, int b)
        {
            return a + b;
        }

        //Procedimento
        static void imprimir(string texto)
        {
            System.Console.WriteLine(texto);
        }

        //Função com 3 parametros        
        static double multiplicacao(double a, double b, double c)
        {
            return a * b * c;
        }

        //Função com valores nos parametros
        static double divisao(double a = 20, double b = 3)
        {
            return a / b;
        }

        //Função com parametros de vetor
        static int somaVetor(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            return soma;
        }

        //Função com parametros de matriz
        static int somaMatriz(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }

            return soma;
        }

        static void Main(string[] args)
        {
            //Chamar função
            int a = 10;
            int b = 30;
            int resultado = soma(a, b);
            System.Console.WriteLine("A soma de {0} e {1} é {2}", a, b, resultado);

            //Chamar procedimento
            imprimir("Olá mundo");

            //Chamar função com 3 parametros
            double a1 = 10;
            double b1 = 20;
            double c1 = 30;
            double resultado1 = multiplicacao(a1, b1, c1);
            System.Console.WriteLine("A multiplicação de {0} x {1} x {2} é {3}", a1, b1, c1, resultado1);

            //Chamar função com valores nos parametros
            double resultado2 = divisao(9, 8);
            System.Console.WriteLine("O resultado da divisão é: {0:f2}", resultado2);

            //Chamar função com vetor
            int[] vetor = { 1, 2, 3, 
                            4, 5, 6, 
                            7, 8, 9 };
            int resultado3 = somaVetor(vetor);
            System.Console.WriteLine("A soma dos elementos do vetor é: {0}", resultado3);

            //Chamar função com matriz
            int[,] matriz = { { 15, 2, 3 }, 
                              { 4, 58, 6 }, 
                              { 7, 8, 94 } };
            int resultado4 = somaMatriz(matriz);
            System.Console.WriteLine("A soma dos elementos da matriz é: {0}", resultado4);
        }
    }
}