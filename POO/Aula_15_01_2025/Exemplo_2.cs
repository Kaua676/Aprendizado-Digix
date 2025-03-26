// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_15_01_2025
// {
//     public class Exemplo_2
//     {
//         static void Main(string[] args)
//         {
//             string filePath = "dados.bin"; // Caminho para o arquivo de dados

//             // Leitura de dados do arquivo
//             using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
//             {
//                 int intValue = reader.ReadInt32(); // Le um inteiro
//                 string stringValue = reader.ReadString(); // Le uma string
//                 double doubleValue = reader.ReadDouble(); // Le um double

//                 System.Console.WriteLine("Inteiro: " + intValue);
//                 System.Console.WriteLine("String: " + stringValue);
//                 System.Console.WriteLine("Double: " + doubleValue);
//             }

//             System.Console.WriteLine("Arquivo de dados lido com sucesso!");
//         }
//     }
// }