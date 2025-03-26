// using System;

// namespace Exemplo12ListPilhFilaENCADEADA
// {
//     class Lista
//     {
//         class Node
//         {
//             public int Valor;          // Valor armazenado no nó
//             public Node? Proximo;      // Referência para o próximo nó
//         }

//         private Node? inicio = null;  // Primeiro nó da lista encadeada

//         // Função para inserir um valor no final da lista
//         public void InserirNoFinal(int valor)
//         {
//             Node novoNode = new Node { Valor = valor, Proximo = null };

//             if (inicio == null)
//             {
//                 inicio = novoNode;
//             }
//             else
//             {
//                 Node atual = inicio;
//                 while (atual.Proximo != null)
//                 {
//                     atual = atual.Proximo;
//                 }
//                 atual.Proximo = novoNode;
//             }
//         }

//         // Função para inserir um valor em uma posição específica
//         public void InserirNaPosicao(int valor, int posicao)
//         {
//             Node novoNode = new Node { Valor = valor };

//             if (posicao < 0)
//             {
//                 Console.WriteLine("Posição inválida.");
//                 return;
//             }

//             if (posicao == 0)
//             {
//                 // Inserir no início da lista
//                 novoNode.Proximo = inicio;
//                 inicio = novoNode;
//             }
//             else
//             {
//                 Node? atual = inicio;
//                 int indice = 0;

//                 // Avança até a posição anterior à desejada
//                 while (atual != null && indice < posicao - 1)
//                 {
//                     atual = atual.Proximo;
//                     indice++;
//                 }

//                 if (atual == null)
//                 {
//                     Console.WriteLine("Posição inválida. A lista é menor que a posição informada.");
//                     return;
//                 }

//                 // Ajusta os ponteiros para inserir o novo nó
//                 novoNode.Proximo = atual.Proximo;
//                 atual.Proximo = novoNode;
//             }
//         }

//         // Função para verificar se um valor está na lista
//         public void Verificar(int valor)
//         {
//             if (inicio == null)
//             {
//                 Console.WriteLine("A lista está vazia.");
//                 return;
//             }

//             Node? atual = inicio;
//             int posicao = 0;

//             while (atual != null)
//             {
//                 if (atual.Valor == valor)
//                 {
//                     Console.WriteLine($"O valor {valor} está na lista");
//                     return;
//                 }
//                 atual = atual.Proximo;
//                 posicao++;
//             }

//             Console.WriteLine($"O valor {valor} não está na lista.");
//         }

//         // Função para listar todos os valores da lista
//         public void Listar()
//         {
//             if (inicio == null)
//             {
//                 Console.WriteLine("A lista está vazia.");
//                 return;
//             }

//             Node? atual = inicio;
//             Console.WriteLine("Elementos na lista:");

//             while (atual != null)
//             {
//                 Console.WriteLine(atual.Valor);
//                 atual = atual.Proximo;
//             }
//         }

//         // Função principal para execução do programa
//         static void Main()
//         {
//             Lista lista = new Lista();

//             // Insere valores no final da lista
//             lista.InserirNoFinal(10);
//             lista.InserirNoFinal(20);
//             lista.InserirNoFinal(30);

//             // Lista os valores na lista
//             Console.WriteLine("Lista inicial:");
//             lista.Listar();

//             // Insere um valor em uma posição específica
//             lista.InserirNaPosicao(25, 2);

//             Console.WriteLine("\nLista após inserir 25 na posição 2:");
//             lista.Listar();

//             // Verifica valores na lista
//             Console.WriteLine();
//             lista.Verificar(20);
//             lista.Verificar(40);
//         }
//     }
// }
