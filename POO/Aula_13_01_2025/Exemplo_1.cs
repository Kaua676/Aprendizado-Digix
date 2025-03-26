// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_13_01_2025
// {
//     public class Exemplo_1
//     {
//         static void Main(string[] args)
//         {
//             // File é uma classe estatica que contem métodos para manipular arquivos
//             string inicio_path = @"C:\Users\kauavicente\Desktop\filereader 1.txt";
//             string final_path = @"C:\Users\kauavicente\Desktop\filereader 2.txt";

//             try
//             {
//                 FileInfo fileInfo = new FileInfo(inicio_path);  // Cria um objeto com referencia endereço criamos do arquivo
//                 // fileInfo.CopyTo(final_path); // Copia do arquivo de origem para o destino
//                 // System.Console.WriteLine("Arquivo copiado com sucesso!");
//                 // Imprimie o que esta escrito no arquivo inicio_path
//                 string [] line = File.ReadAllLines(inicio_path);
//                 for (int i = 0; i < line.Length; i++)
//                 {
//                     System.Console.WriteLine(line[i]);
//                 }

//             }
//             catch (IOException e) // IO Exception eh uma classe que representa erros de entrada e saida
//             {
//                 System.Console.WriteLine("errooooooooooooo" + e.Message);
//             }
//         }
//     }
// }