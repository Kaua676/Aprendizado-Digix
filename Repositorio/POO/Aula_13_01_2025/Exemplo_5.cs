// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using System.Collections.Generic;

// namespace Aula_13_01_2025
// {
//     public class Exemplo_5
//     {
//         static void Main(string[] args)
//         {
//             string path = @"C:\Users\kauavicente\Desktop\aaaa";

//             try
//             {
//                 // Directory é uma classe estatica que permite manipulação dos diretorios. 
//                 // EnumerateDirectories que está listando os diretorios/pastas
//                 // AllDirectories define a busca de todos os diretorios e subdiretorios
//                 IEnumerable<string> folders = Directory.EnumerateFileSystemEntries(path, "*.*", SearchOption.AllDirectories);

//                 foreach (string folder in folders)
//                 {
//                     System.Console.WriteLine(folder);
//                 }

//                 // Enumerar arquivos
//                 IEnumerable<string> files = Directory.EnumerateFileSystemEntries(path, "*.*", SearchOption.TopDirectoryOnly);
//                 foreach (string file in files)
//                 {
//                     System.Console.WriteLine(file);
//                 }

//                 // Criar um novo diretorio
//                 // string newFolder = @"C:\Users\kauavicente\Desktop\aaaa\novoDiretorio";
//                 // Directory.CreateDirectory(newFolder);

//                 // Deletar um diretorio
//                 // Directory.Delete(newFolder, true);
//                 // System.Console.WriteLine("Diretorio deletado com sucesso! + " + newFolder);

//                 // Verificar se a pasta existe
//                 bool existe = Directory.Exists(path + @"\novoDiretorio");
//                 System.Console.WriteLine("A pasta existe: " + existe);
//             }
//             catch (IOException ex)
//             {
//                 System.Console.WriteLine("Erro ao ler o arquivo! + " + ex.Message);
//             }
//         }
//     }
// }