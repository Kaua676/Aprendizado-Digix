using System;

namespace Desafio
{
    class Program
    {
        //Calcula a media do mes e imprime por região
        static void mediaMes(double[,,] matriz)
        {
            double media = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz.GetLength(2); k++)
                    {
                        media += matriz[i, j, k];
                    }
                }
                System.Console.WriteLine($"Média da região {i + 1}: {media / 12:F2}°C");
                media = 0;
            }
        }

        // Calcula a media da semana e imprime por regiao
        static void mediaSemana(double[,,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                System.Console.WriteLine($"Região {i + 1}: ");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine($"Mês {j + 1}: ");
                    for (int k = 0; k < matriz.GetLength(2); k++)
                    {
                        System.Console.WriteLine($"semana {k + 1}: {matriz[i, j, k]}°C");
                    }
                }
            }
        }
        
        // Exercicio 4
        static string mediaRegiao(double[,,] matriz)
        {
            double regiao1 = 0;
            double regiao2 = 0;
            double regiao3 = 0;
            double regiao4 = 0;

            // Soma dos valores para a Região 1
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                for (int k = 0; k < matriz.GetLength(2); k++)
                {
                    regiao1 += matriz[0, j, k];
                }
            }

            // Soma dos valores para a Região 2
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                for (int k = 0; k < matriz.GetLength(2); k++)
                {
                    regiao2 += matriz[1, j, k];
                }
            }

            // Soma dos valores para a Região 3
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                for (int k = 0; k < matriz.GetLength(2); k++)
                {
                    regiao3 += matriz[2, j, k];
                }
            }

            // Soma dos valores para a Região 4
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                for (int k = 0; k < matriz.GetLength(2); k++)
                {
                    regiao4 += matriz[3, j, k];
                }
            }

            // Agora calculamos a média de cada região (dividindo pela quantidade de elementos: 12)
            regiao1 /= 12;
            regiao2 /= 12;
            regiao3 /= 12;
            regiao4 /= 12;

            // Comparando para ver qual região tem a maior média
            double maiorValor = regiao1;
            string maiorRegiao = "Região 1";

            if (regiao2 > maiorValor)
            {
                maiorValor = regiao2;
                maiorRegiao = "Região 12";
            }
            if (regiao3 > maiorValor)
            {
                maiorValor = regiao3;
                maiorRegiao = "Região 3";
            }
            if (regiao4 > maiorValor)
            {
                maiorValor = regiao4;
                maiorRegiao = "Região 4";
            }

            // Retorna a maior média
            return $"A região com a maior média de temperatura é a {maiorRegiao} com {maiorValor:F2}°C";
        }

        static void Main(string[] args)
        {
            //1° Profundidade
            //2° Linha
            //3° Coluna

            double[,,] temperaturas = new double[4, 3, 4]
            {
                //Região 1
                {
        //semanas     1      2     3     4
                    {22.2, 25.3, 27.2, 24.1}, //mes 1
                    {24.1, 22.8, 28.6, 31.3}, //mes 2
                    {26.6, 25.5, 23.8, 29.1}, //mes 3
                },
                //Região 2
                {
        //semanas     1      2     3     4           
                    {2.2, 2.3, 2.2, 2.1}, //mes 1
                    {2.1, 2.8, 2.6, 3.3}, //mes 2
                    {2.6, 2.5, 2.8, 2.1}, //mes 3
                },
                //Região 3
                {
        //semanas     1      2     3     4           
                    {12.2, 15.3, 17.2, 14.1}, //mes 1
                    {14.1, 12.8, 18.6, 11.3}, //mes 2
                    {16.6, 15.5, 13.8, 19.1}, //mes 3
                },
                //Região 4
                {
        //semanas     1      2     3     4
                    {32.2, 35.3, 37.2, 34.1}, //mes 1
                    {34.1, 32.8, 38.6, 31.3}, //mes 2
                    {36.6, 35.5, 33.8, 39.1}, //mes 3
                },

            };
            //Retorna a função mediaSemana
            System.Console.WriteLine("Á média de temperatura de cada semana é: ");
            mediaSemana(temperaturas);

            //Retorna a função mediaMes
            System.Console.WriteLine("Á média de temperatura de cada região ao longo dos 3 meses é: ");
            mediaMes(temperaturas);

            //Retorna a função maior mediaRegiao
            System.Console.WriteLine(mediaRegiao(temperaturas));
        }
    }
}
