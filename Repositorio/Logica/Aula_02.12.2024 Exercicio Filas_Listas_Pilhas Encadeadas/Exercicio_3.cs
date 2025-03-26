// using System;

// namespace XXXXXXX
// {
//     public class Pilha
//     {
//         // Classe Node para representar cada elemento da pilha
//         private class Node
//         {
//             public int Valor;         // Valor armazenado no nó
//             public Node? Proximo;     // Referência para o próximo nó
//         }

//         private Node? topo = null;    // Representa o topo da pilha

//         // Adiciona um elemento na pilha (Push)
//         public void Adicionar(int valor)
//         {
//             Node novoNode = new Node { Valor = valor, Proximo = topo };
//             topo = novoNode;
//         }

//         // Ver o topo da pilha
//         public void VerTopo()
//         {
//             if (topo == null)
//             {
//                 Console.WriteLine("A pilha está vazia.");
//             }
//             else
//             {
//                 Console.WriteLine("O topo da pilha é: " + topo.Valor);
//             }
//         }

//         // Lista os elementos da pilha do topo para a base
//         public void Listar()
//         {
//             if (topo == null)
//             {
//                 Console.WriteLine("A pilha está vazia.");
//                 return;
//             }

//             Console.WriteLine("Elementos na pilha:");
//             Node? atual = topo;
//             while (atual != null)
//             {
//                 Console.WriteLine(atual.Valor);
//                 atual = atual.Proximo;
//             }
//         }

//         // Método principal para teste
//         static void Main(string[] args)
//         {
//             Pilha pilha = new Pilha();

//             // Adiciona elementos na pilha
//             pilha.Adicionar(10);
//             pilha.Adicionar(20);
//             pilha.Adicionar(30);

//             // Lista os elementos da pilha
//             pilha.Listar();

//             // Exibe o elemento no topo da pilha
//             pilha.VerTopo();
//         }
//     }
// }
