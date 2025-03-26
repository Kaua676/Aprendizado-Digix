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

//         // Reverte a pilha
//         public void Reverter()
//         {
//             if (topo == null || topo.Proximo == null)
//             {
//                 Console.WriteLine("A pilha está vazia ou tem apenas um elemento, não é necessário reverter.");
//                 return;
//             }

//             Node? anterior = null;
//             Node? atual = topo;
//             Node? proximo = null;

//             while (atual != null)
//             {
//                 proximo = atual.Proximo;  // Armazena a referência ao próximo nó
//                 atual.Proximo = anterior; // Inverte a direção do ponteiro
//                 anterior = atual;         // Avança o nó anterior
//                 atual = proximo;          // Avança para o próximo nó
//             }

//             topo = anterior; // Atualiza o topo da pilha
//             Console.WriteLine("Pilha revertida com sucesso.");
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
//             Console.WriteLine("Pilha original:");
//             pilha.Listar();

//             // Reverte a pilha
//             pilha.Reverter();

//             // Lista os elementos da pilha após a reversão
//             Console.WriteLine("Pilha após reversão:");
//             pilha.Listar();
//         }
//     }
// }
