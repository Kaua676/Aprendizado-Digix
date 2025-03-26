// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_13_01_2025
// {
//     public class Exemplo_3
//     {
//         static void Main(string[] args)
//         {
//             // Isso é uma conversa com o sistema operacionale não é gerenciado pelo Clr
//             string inicio_path = @"C:\Users\kauavicente\Desktop\filereader 1.txt";

//             try
//             {
//                 using (FileStream fs = new FileStream(inicio_path, FileMode.Open))
//                 {
//                     using (StreamReader sr = new StreamReader(fs))
//                     {
//                         string line = sr.ReadLine();
//                         while (line != null)
//                         {
//                             System.Console.WriteLine(line.Trim());
//                             line = sr.ReadLine();
//                         }
//                     }
//                 }
//             }
//             catch (IOException e)
//             {
//                 System.Console.WriteLine("Erro ao ler o arquivo! + " + e.Message);
//             }
//         }
//     }
// }