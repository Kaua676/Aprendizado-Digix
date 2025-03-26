// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_15_01_2025
// {
//     public class Exemplo_1
//     {
//         static void Main(string[] args)
//         {
//             string filePath = "dados.bin"; // Caminho para o arquivo de dados

//             // Escreve os dados do arquivo
//             using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
//             {
//                 writer.Write(10); // Escreve um inteiro
//                 writer.Write("Ola, Mundo!"); // Escreve uma string
//                 writer.Write(45.54843151652); // Escreve um double
//             }

//             System.Console.WriteLine("Arquivo de dados criado com sucesso!");


//         }
//     }
// }