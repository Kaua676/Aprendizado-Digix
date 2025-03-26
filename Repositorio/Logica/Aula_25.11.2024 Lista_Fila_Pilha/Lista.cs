// using System;

// namespace Lista
// {
//     public class Program
//     {
//         static int[] vetor = new int[10];
        
//         //Metodo inserir
//         static void Inserir(int valor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 if (vetor[i] == 0)
//                 {
//                     vetor[i] = valor;
//                     break;
//                 }
//             }
//         }

//         //Metodo excluir
//         static void Remover(int valor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 if (vetor[i] == valor)
//                 {
//                     vetor[i] = 0;
//                     break;
//                 }
//             }
//         }

//         //Metodo listar
//         static void Listar()
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 if (vetor[i] != 0)
//                 {
//                     Console.WriteLine(vetor[i]);
//                 }
//             }
//         }

//         //Listar de forma inversa
//         static void ListarInverso()
//         {
//             for (int i = vetor.Length - 1; i >= 0; i--)
//             {
//                 if (vetor[i] != 0)
//                 {
//                     Console.WriteLine(vetor[i]);
//                 }
//             }
//         }

//         static void Main(string[] args)
//         {
//             Inserir(10);
//             Inserir(20);
//             Inserir(30);
//             Inserir(40);
//             Inserir(50);
//             Inserir(60);
//             Inserir(70);
//             Inserir(80);
//             Inserir(90);
//             Inserir(100);
//             Listar();
//             System.Console.WriteLine("Listar de forma inversa: ");
//             ListarInverso();
//             Remover(50);
//             System.Console.WriteLine("Listar após remover o valor 50");
//             Listar();
        

//         }
//     }
// }