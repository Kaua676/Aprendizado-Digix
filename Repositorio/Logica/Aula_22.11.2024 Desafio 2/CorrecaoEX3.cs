using System;

namespace Exercicio_3
{
    public class Program
    {
        static void SelectionSort(string[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (EhMenor(Array[j], Array[minIndex]))
                    {
                        minIndex = j;
                    }
                }
                string temp = Array[i];
                Array[i] = Array[minIndex];
                Array[minIndex] = temp;
            }
        }

        static bool EhMenor(string a, string b)
        {
            int tamanho = Math.Min(a.Length, b.Length);
            for (int i = 0; i < tamanho; i++)
            {
                if (a[i] < b[i])
                {
                    return true;
                }
                else if (a[i] > b[i])
                {
                    return false;
                }
            }
            return a.Length < b.Length;
        }

        static void Imprimir(string[] Array)
        {
            for (int i = 0; i < Array.Length; i++) // Corrigido de Array.Count para Array.Length
            {
                Console.WriteLine(Array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            string[] nomes = { "João", "Maria", "Pedro", "Ana", "Lucas", "Mariana", "Rafael", "Camila", "Gustavo", "Leticia" };
            SelectionSort(nomes);
            Imprimir(nomes);
        }
    }
}
