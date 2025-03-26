// using System;

// namespace XXXXXXX
// {
//     public class Fila
//     {
//         // Classe Node para representar cada elemento da fila
//         private class Node
//         {
//             public int Valor;         // Valor armazenado no nó
//             public Node? Proximo;     // Referência para o próximo nó
//         }

//         private Node? inicio = null; // Representa o início da fila
//         private Node? fim = null;    // Representa o final da fila
//         private int count = 0;       // Contador para a quantidade de elementos na fila

//         // Adicionar um elemento na fila (enqueue)
//         public void Adicionar(int valor)
//         {
//             Node novoNode = new Node { Valor = valor, Proximo = null };

//             if (inicio == null)
//             {
//                 // Caso a fila esteja vazia, o novo nó se torna o início e o fim
//                 inicio = novoNode;
//                 fim = novoNode;
//             }
//             else
//             {
//                 // Caso contrário, adiciona o nó no final da fila
//                 fim!.Proximo = novoNode;
//                 fim = novoNode;
//             }

//             count++; // Incrementa o contador
//         }

//         // Listar os elementos da fila
//         public void Listar()
//         {
//             if (inicio == null)
//             {
//                 Console.WriteLine("A fila está vazia.");
//                 return;
//             }

//             Console.WriteLine("Elementos na fila:");
//             Node? atual = inicio;
//             while (atual != null)
//             {
//                 Console.WriteLine(atual.Valor);
//                 atual = atual.Proximo;
//             }
//         }

//         // Verifica a quantidade de elementos na fila
//         public void QuantidadeElementos()
//         {
//             Console.WriteLine($"Quantidade de elementos na fila: {count}");
//         }

//         // Método principal para teste
//         static void Main(string[] args)
//         {
//             Fila fila = new Fila();

//             // Adiciona elementos na fila
//             fila.Adicionar(10);
//             fila.Adicionar(20);

//             // Lista os elementos da fila
//             fila.Listar();

//             // Verifica a quantidade de elementos na fila
//             fila.QuantidadeElementos();
//         }
//     }
// }
