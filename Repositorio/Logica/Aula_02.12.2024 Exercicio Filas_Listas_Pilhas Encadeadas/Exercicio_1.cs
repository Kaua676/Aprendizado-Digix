// using System;

// namespace ListaEncadeada
// {
//     class Node
//     {
//         public int Valor;      // Valor armazenado no nó
//         public Node? Proximo;  // Referência para o próximo nó na lista encadeada
//     }

//     class ListaEncadeada
//     {
//         private Node? inicio = null;  // Início da lista encadeada

//         // Método para inserir um valor em uma posição específica
//         public void Inserir(int valor, int posicao)
//         {
//             var novoNode = new Node { Valor = valor };

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
//                 var atual = inicio;
//                 int indice = 0;

//                 // Avança até a posição anterior ao local de inserção
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

//                 // Ajusta as referências para inserir o novo nó
//                 novoNode.Proximo = atual.Proximo;
//                 atual.Proximo = novoNode;
//             }
//         }

//         // Método para listar todos os valores da lista
//         public void Listar()
//         {
//             var atual = inicio;

//             if (atual == null)
//             {
//                 Console.WriteLine("A lista está vazia.");
//                 return;
//             }

//             while (atual != null)
//             {
//                 Console.WriteLine(atual.Valor);
//                 atual = atual.Proximo;
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var lista = new ListaEncadeada();

//             // Inserindo valores iniciais
//             lista.Inserir(10, 0);
//             lista.Inserir(20, 1);
//             lista.Inserir(30, 2);

//             Console.WriteLine("Lista após inserções iniciais:");
//             lista.Listar();

//             // Inserindo um valor no meio
//             lista.Inserir(25, 2);

//             Console.WriteLine("Lista após inserir 25 na posição 2:");
//             lista.Listar();
//         }
//     }
// }
