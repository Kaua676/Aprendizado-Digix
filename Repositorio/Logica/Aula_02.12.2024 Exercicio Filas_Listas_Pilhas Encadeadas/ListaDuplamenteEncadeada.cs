// using System;
// namespace Name
// {
//     public class ListaDuplamenteEncadeada
//     {
//         class Node
//         {
//             public int valor;
//             public Node? proximo;
//             public Node? anterior;
//         }
//         static Node? inicio = null;

//         static void Inserir(int valor)
//         {
//             Node novoNode = new Node { valor = valor, proximo = null, anterior = null };
//             if (inicio == null)
//             {
//                 inicio = novoNode;
//             }
//             else
//             {
//                 Node atual = inicio;
//                 while (atual.proximo != null)
//                 {
//                     atual = atual.proximo;
//                 }
//                 atual.proximo = novoNode;
//                 novoNode.anterior = atual;
//             }
//         }

//         static void Remover(int valor)
//         {
//             // Verifica se a pilha está vazia
//             if (inicio == null)
//             {
//                 Console.WriteLine("Pilha vazia.");
//                 return;
//             }
//             if (inicio.valor == valor)
//             {
//                 if (inicio.proximo != null)
//                 {
//                     inicio.proximo.anterior = null;
//                 }
//                 inicio = inicio.proximo;
//                 return;
//             }

//             //Percorrer a lista para encontrar o nó com o valor desejado
//             Node atual = inicio;
//             while (atual.proximo != null && atual.valor != valor)
//             {
//                 atual = atual.proximo;
//             }

//             //Verifica se o nó foi encontrado
//             if (atual != null)
//             {
//                 if (atual.anterior != null)
//                 {
//                     atual.anterior.proximo = atual.proximo;
//                 }
//                 if (atual.proximo != null)
//                 {
//                     atual.proximo.anterior = atual.anterior;
//                 }
//             }
//         }

//         static void Imprimir()
//         {
//             Node? atual = inicio;
//             while (atual != null)
//             {
//                 Console.WriteLine(atual.valor);
//                 atual = atual.proximo;
//             }
//         }

//         static void Main(string[] args)
//         {
//             Inserir(1);
//             Inserir(2);
//             Inserir(3);
//             Imprimir();
//             Remover(2);
//             Imprimir();
//         }
//     }
// }
