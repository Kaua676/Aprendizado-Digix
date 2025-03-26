// using System;
// using System.IO;

// namespace Aula_17_01_2025
// {
//     public class Executar
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite o número de linhas da matriz (N): ");
//             int n = int.Parse(Console.ReadLine());
//             System.Console.WriteLine("Digite o número de colunas da matriz (M): ");
//             int m = int.Parse(Console.ReadLine());

//             int[,] matriz = new int[n, m];
//             Random random = new Random();

//             System.Console.WriteLine("Matriz gerada:");
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < m; j++)
//                 {
//                     matriz[i, j] = random.Next(1, 100);
//                     System.Console.Write(matriz[i, j] + " ");
//                 }
//                 System.Console.WriteLine();
//             }

//             System.Console.WriteLine("\nComo deseja manipular a matriz?");
//             System.Console.WriteLine("1 - Calcular a soma de cada linha");
//             System.Console.WriteLine("2 - Calcular a soma de cada coluna");
//             System.Console.WriteLine("3 - Transpor a matriz (trocar linhas por colunas)");

//             string filepath = "resultado.csv";
//             try
//             {
//                 int opcao = int.Parse(Console.ReadLine());
//                 using (StreamWriter writer = new StreamWriter(filepath))
//                 {
//                     switch (opcao)
//                     {
//                         case 1:
//                             SomarLinhas(matriz, writer);
//                             break;
//                         case 2:
//                             SomarColunas(matriz, writer);
//                             break;
//                         case 3:
//                             TransporMatriz(matriz, writer);
//                             break;
//                         default:
//                             System.Console.WriteLine("Opção inválida!");
//                             break;
//                     }
//                 }
//                 System.Console.WriteLine($"Resultado salvo no arquivo: {filepath}");
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Erro: {ex.Message}");
//             }
//         }

//         public static void SomarLinhas(int[,] matriz, StreamWriter writer)
//         {
//             int n = matriz.GetLength(0);
//             int m = matriz.GetLength(1);
//             for (int i = 0; i < n; i++)
//             {
//                 int soma = 0;
//                 for (int j = 0; j < m; j++)
//                 {
//                     soma += matriz[i, j];
//                 }
//                 writer.WriteLine($"Soma da linha {i}: {soma}");
//             }
//         }

//         public static void SomarColunas(int[,] matriz, StreamWriter writer)
//         {
//             int n = matriz.GetLength(0);
//             int m = matriz.GetLength(1);
//             for (int j = 0; j < m; j++)
//             {
//                 int soma = 0;
//                 for (int i = 0; i < n; i++)
//                 {
//                     soma += matriz[i, j];
//                 }
//                 writer.WriteLine($"Soma da coluna {j}: {soma}");
//             }
//         }

//         public static void TransporMatriz(int[,] matriz, StreamWriter writer)
//         {
//             int n = matriz.GetLength(0);
//             int m = matriz.GetLength(1);
//             int[,] transposta = new int[m, n];
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < m; j++)
//                 {
//                     transposta[j, i] = matriz[i, j];
//                 }
//             }
//             for (int i = 0; i < m; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     writer.Write(transposta[i, j] + " ");
//                 }
//                 writer.WriteLine();
//             }
//         }
//     }
// }