using System;

namespace Funcao_Recursiva
{
    class Program
    {
        //Identifica quantos numeros pares existem no vetor
        static int[] ObterPares(int[] vetor, int indice = 0)
        {
            if (indice >= vetor.Length)
            {
                return new int[0];
            }

            int[] paresRestantes = ObterPares(vetor, indice + 1);
            if (vetor[indice] % 2 == 0)
            {
                int[] resultado = new int[paresRestantes.Length + 1];
                resultado[0] = vetor[indice];
                paresRestantes.CopyTo(resultado, 1);
                return resultado;
            }
            else
            {
                return paresRestantes;
            }
        }

        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                            11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                            21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] pares = ObterPares(vetor);
            
            foreach (var item in pares)
            {
                Console.WriteLine(item);
            }
        }
    }
}
