// Equipe 3
// 1 Arthur Duarte 
// 2 Henrique Oliveira Silva
// 3 José Lucas Rocha
// 4 Kauã Vicente Domingos


using System;

namespace XXXXXXX
{
    class Program
    {
        static double MediaGeral(string[,] matriz)
        {
            double soma = 0;
            int totalNotas = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    soma += Convert.ToDouble(matriz[i, j]);
                    totalNotas++;
                }
            }
            double media = soma / totalNotas;

            return media;
        }

        static void Media(string[,] funcionarios)
        {

            double soma = 0;
            double media = 0;
            for (int i = 0; i < funcionarios.GetLength(0); i++)
            {
                soma = 0;
                for (int j = 1; j < funcionarios.GetLength(1) - 1; j++)
                {
                    var funcionariosNum = double.Parse(funcionarios[i, j]);
                    soma += funcionariosNum;
                    if (j == 4)
                    {
                        media = soma / 4;
                        funcionarios[i, 5] = media.ToString();
                    }

                }
            }
        }

        static void AcimaMedia(string[,] funcionarios)
        {
            System.Console.WriteLine("Os funcionarios que estão acima da média são:");
            for (int i = 0; i < funcionarios.GetLength(0); i++)
            {
                var funcionariosNum = double.Parse(funcionarios[i, 5]);
                if (funcionariosNum > MediaGeral(funcionarios))
                {
                    System.Console.WriteLine($"{funcionarios[i, 0]}: {funcionarios[i, 5]}");
                }
            }
        }

        static void MelhorPior(string[,] funcionarios)
        {
            double melhor = 0;
            double pior = 10;
            int nomMelhor = 0;
            int nomePior = 0;
            for (int i = 0; i < funcionarios.GetLength(0); i++)
            {
                var funcionariosNum = double.Parse(funcionarios[i, 5]);
                if (melhor < funcionariosNum)
                {
                    melhor = funcionariosNum;
                    nomMelhor = i;
                }
                else if (pior > funcionariosNum)
                {
                    pior = funcionariosNum;
                    nomePior = i;
                }
            }
            System.Console.WriteLine($"O funcionario com o melhor desempenho é o {funcionarios[nomMelhor, 0]}: {melhor} \nO funcionario com o pior desempenho é o {funcionarios[nomePior, 0]}: {pior}");
        }
        static void OrdenarFuncionarios(string[,] funcionarios)
        {
            for (int i = 0; i < funcionarios.GetLength(0) - 1; i++)
            {
                int mediaDesempenho = i;

                for (int j = i + 1; j < funcionarios.GetLength(0); j++)
                {
                    double valorAutal = double.Parse(funcionarios[j, 5]);
                    double minValor = double.Parse(funcionarios[mediaDesempenho, 5]);

                    if (valorAutal > minValor || (valorAutal == minValor && String.Compare(funcionarios[j, 0], funcionarios[mediaDesempenho, 0]) < 0))
                    {
                        mediaDesempenho = j;
                    }
                }

                if (mediaDesempenho != i)
                {
                    for (int k = 0; k < funcionarios.GetLength(1); k++)
                    {
                        string temp = funcionarios[i, k];
                        funcionarios[i, k] = funcionarios[mediaDesempenho, k];
                        funcionarios[mediaDesempenho, k] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string[,] funcionarios = new string[20, 6]
            {
                { "Alice", "8", "9", "7", "6", "0.00" },
                { "Bruno", "5", "6", "8", "7", "0.00" },
                { "Carla", "9", "8", "7", "9", "0.00" },
                { "Diego", "6", "5", "7", "8", "0.00" },
                { "Eduarda", "4", "6", "5", "7", "0.00" },
                { "Felipe", "7", "8", "6", "9", "0.00" },
                { "Gabriela", "8", "9", "7", "8", "0.00" },
                { "Hugo", "6", "5", "8", "7", "0.00" },
                { "Isabela", "9", "8", "9", "10", "0.00" },
                { "João", "5", "6", "7", "6", "0.00" },
                { "Larissa", "7", "8", "8", "7", "0.00" },
                { "Marcos", "6", "5", "7", "8", "0.00" },
                { "Natália", "8", "9", "7", "6", "0.00" },
                { "Otávio", "4", "6", "5", "7", "0.00" },
                { "Paula", "9", "8", "9", "10", "0.00" },
                { "Rafael", "6", "5", "8", "7", "0.00" },
                { "Sofia", "7", "8", "6", "9", "0.00" },
                { "Tiago", "5", "6", "7", "6", "0.00" },
                { "Valéria", "8", "9", "7", "8", "0.00" },
                { "Yuri", "7", "8", "8", "7", "0.00" }
            };

            Media(funcionarios);
            System.Console.WriteLine($"Media geral: {MediaGeral(funcionarios):f2}");
            OrdenarFuncionarios(funcionarios);
            AcimaMedia(funcionarios);
            MelhorPior(funcionarios);
        }
    }
}