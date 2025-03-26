// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_13_01_2025
// {
//     public class Exemplo_2
//     {
//         static void Main(string[] args)
//         {
//             // Isso é uma conversa com o sistema operacionale não é gerenciado pelo Clr
//             string inicio_path = @"C:\Users\kauavicente\Desktop\filereader 1.txt";
//             FileStream fs = null; // Essa é uma classe que permite leitura e escrita de arquivos e é uma classe de baixo nivel
//             StreamReader sr = null; // Também é uma classe de manioulação de arquivo como a FileStream mas é de alto nivel

//             try
//             {
//                 fs = new FileStream(inicio_path, FileMode.Open); // Abre o arquivo
//                 sr = new StreamReader(fs); // Abre o arquivo para leitura
//                 string line = sr.ReadLine(); // Le o arquivo
//                 while (line != null)
//                 {
//                     System.Console.WriteLine(line.Trim());
//                     line = sr.ReadLine();
//                 }
//             }
//             catch (IOException e)
//             {
//                 System.Console.WriteLine("Erro ao ler o arquivo! + " + e.Message);
//             }
//             finally
//             { 
//                 // Eu preciso fehcar o arquivo, pois o sistema operacional não faz isso automaticamente
//                 if (sr != null) sr.Close();
//                 if (fs != null) fs.Close();
//             }
//         }
//     }
// }