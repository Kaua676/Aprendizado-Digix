using System;

namespace Matriz_Tridimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz Tridimensional
            //Na tridimensional, 3 indices
            //1 Indice: Linha
            //2 Indice: Coluna
            //3 Indice: Profundidade

            int[,,] matriz3D = new int[2, 2, 2]{
                {{1, 2},
                {3, 4}},

                {{5, 6},
                {7, 8}}
            };

            //Percorrer a Matriz
            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                        System.Console.WriteLine($"[{i}, {j}, {k}] = {matriz3D[i, j, k]}");
                    }
                }
            }

            // Acessar um elemento da matriz
            System.Console.WriteLine(matriz3D[1, 1, 1]);
            System.Console.WriteLine(matriz3D[1, 1, 0]);
            System.Console.WriteLine(matriz3D[0, 0, 0]);

            // Alterar o valor de um elemento da matriz
            matriz3D[1, 1, 1] = 100;
            Console.WriteLine(matriz3D[1, 1, 1]);

            // Somar todos os elementos da matriz
            int soma = 0;
            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                        soma += matriz3D[i, j, k];
                    }
                }
            }
            System.Console.WriteLine(soma);

            //Percorrer a Matriz com foreach
            foreach (int i in matriz3D)
            {
                System.Console.WriteLine(i);
            }


        }
    }
}
