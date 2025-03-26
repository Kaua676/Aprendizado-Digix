using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int[] numerosInversos = new int[10];

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = r.Next(100);
                Console.WriteLine($"numeros[{i}]: {numeros[i]}");
            }

            int contador = 0;
            for (int i = 9; i >= 0; i--)
            {
                numerosInversos[contador] = numeros[i];
                contador++;
                Console.WriteLine($"numerosInversos[{contador}]: {numerosInversos[contador]}");
                
            }
            
            if(numeros == numerosInversos){
                System.Console.WriteLine("\nOs numeros sao iguais");
            }
            else{
                System.Console.WriteLine("\nOs numeros sao diferentes");
            }
        }
    }
}
