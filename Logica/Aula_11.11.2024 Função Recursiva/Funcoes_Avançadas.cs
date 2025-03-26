using System;

namespace Funcoes_Avançadas
{
    class Program
    {

        static void Main(string[] args)
        {
            //Estrutura Linq é uma forma de faer consultas em coleções array, list, etc...
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var é uma variavel implicita, que é um objeto que pode receber qualquer tipo de variavel
            var impares = numeros.Where(n => n % 2 != 0).ToArray();

            foreach (var numero in impares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
