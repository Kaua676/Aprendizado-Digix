using System;

namespace Exercicio_3
{
    public class Program
    {
        static void Ordernar(List<string> vetor)
        {
            string menor, aux;

            for (int i = 0; i < vetor.Count; i++)
            {
                menor = vetor[i];
                for (int j = i + 1; j < vetor.Count; j++)
                {
                    if (vetor[j].CompareTo(menor) < 0)
                    {
                        menor = vetor[j];
                        aux = vetor[i];
                        vetor[i] = menor;
                        vetor[j] = aux;
                    }
                }
            }
        }

        static void Imprimir(List<string> vetor)
        {
            for (int i = 0; i < vetor.Count; i++)
            {
                Console.WriteLine(vetor[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            List<string> vetor = new List<string>();

            while (true)
            {
                Console.WriteLine("Digite um nome (ou pressione Enter para finalizar): ");
                string nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    break;
                }

                vetor.Add(nome);
            }

            Ordernar(vetor);
            Console.WriteLine("Vetor ordenado: ");
            Imprimir(vetor);
        }
    }
}
