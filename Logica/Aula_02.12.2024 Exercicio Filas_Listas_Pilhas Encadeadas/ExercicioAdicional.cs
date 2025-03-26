using System;

namespace ListaDuplamenteEncadeada
{
    // Classe Node para representar um nó na lista duplamente encadeada
    public class Node
    {
        public int Valor;
        public Node? Proximo;
        public Node? Anterior;

        // Classe que representa a lista duplamente encadeada
        public class ListaDuplamenteEncadeada
        {
            private Node? inicio = null;
            private Node? fim = null;

            public void Adicionar(int valor)
            {
                Node novoNode = new Node { Valor = valor, Proximo = null, Anterior = null };

                if (inicio == null)
                {
                    inicio = novoNode;
                    fim = novoNode;
                }
                else
                {
                    fim!.Proximo = novoNode;
                    novoNode.Anterior = fim;
                    fim = novoNode;
                }
            }

            public void Listar()
            {
                if (inicio == null)
                {
                    Console.WriteLine("A lista está vazia.");
                    return;
                }

                Node? atual = inicio;
                while (atual != null)
                {
                    Console.Write(atual.Valor);
                    if (atual.Proximo != null)
                        Console.Write(" <-> ");
                    atual = atual.Proximo;
                }
                Console.WriteLine();
            }

            public void Remover(int valor)
            {
                Node? atual = inicio;

                // Percorre a lista
                while (atual != null)
                {
                    if (atual.Valor == valor)
                    {
                        if (atual.Anterior == null)
                        {
                            inicio = atual.Proximo;
                            if (inicio != null)
                            {
                                inicio.Anterior = null;
                            }
                        }
                        else if (atual.Proximo == null)
                        {
                            fim = atual.Anterior;
                            if (fim != null)
                            {
                                fim.Proximo = null;
                            }
                        }
                        else
                        {
                            atual.Anterior!.Proximo = atual.Proximo;
                            atual.Proximo!.Anterior = atual.Anterior;
                        }
                    }
                    atual = atual.Proximo;
                }
            }

            static void Main(string[] args)
            {
                ListaDuplamenteEncadeada lista = new ListaDuplamenteEncadeada();

                lista.Adicionar(10);
                lista.Adicionar(20);
                lista.Adicionar(30);
                lista.Adicionar(20);
                lista.Adicionar(40);

                Console.WriteLine("Lista original:");
                lista.Listar();

                lista.Remover(20);

                Console.WriteLine("Lista após remover todas as ocorrências de 20:");
                lista.Listar();
            }
        }
    }
}
