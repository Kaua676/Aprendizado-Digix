// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Runtime.CompilerServices;
// using System.Threading.Tasks;

// namespace Aula_13_01_2025
// {
//     public class Exemplo_4
//     {
//         static void Main(string[] args)
//         {
//             string inicio_path = @"C:\Users\kauavicente\Desktop\filereader 1.txt";
//             string final_path = @"C:\Users\kauavicente\Desktop\filereader 2.txt";

//             try
//             {
//                 string [] lines = File.ReadAllLines(inicio_path);
//                 using (StreamWriter sw = new StreamWriter(final_path))
//                 {
//                     foreach (string line in lines)
//                     {
//                         sw.WriteLine(line.ToUpper());
//                     }
//                 }
//                 System.Console.WriteLine("Funcionou filha da puta");
//             }
//             catch (IOException e) 
//             {
//                 System.Console.WriteLine("An error occurred: " + e.Message);
//             }
//         }
//     }
// }