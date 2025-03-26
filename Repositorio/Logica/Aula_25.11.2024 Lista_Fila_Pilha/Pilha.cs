// using System;

// namespace XXXXXXX
// {
//     public class Pilha
//     {
//         static int[] pilha = new int[10];

//         static int topo = 0; //Topo da pilha

//         //Adiciona um elemento na pilha, push
//         public static void Adicionar(int valor)
//         {
//             if (topo < pilha.Length)
//             {
//                 pilha[topo] = valor;
//                 topo++; //Incrementa o topo
//             }
//             else
//             {
//                 System.Console.WriteLine("Pilha cheia!");
//             }
//         }

//         // Remove um elementyo da pilha, pop
//         static void Remover()
//         {
//             if (topo > 0)
//             {
//                 topo--; //Decrementa o topo
//                 pilha[topo] = 0;
//             }
//             else
//             {
//                 System.Console.WriteLine("Pilha vazia!");
//             }
//         }

//         //ListaR os elementos da pilha do topo para a base
//         static void Listar()
//         {
//             for (int i = topo - 1; i >= 0; i--)
//             {
//                 System.Console.WriteLine(pilha[i]);
//             }
//         }

//         static void Main(string[] args)
//         {
//             Adicionar(10);
//             Adicionar(20);
//             Adicionar(30);
//             Adicionar(40);
//             Adicionar(50);
//             Adicionar(60);
//             Adicionar(70);
//             Adicionar(80);
//             Adicionar(90);
//             Adicionar(100);

//             Listar();

//             Remover();

//             Listar();
//         }
//     }
// }