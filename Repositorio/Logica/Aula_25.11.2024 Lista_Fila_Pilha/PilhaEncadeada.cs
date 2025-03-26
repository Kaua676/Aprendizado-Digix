using System;

namespace PilhaEncadeada
{
    class PilhaEncadeada
    {
        class Node
        {
            public int Valor;
            public Node? Proximo;
        }

        static Node? topo = null;

        //Empilha e adiciona um elemento ao topo da pilha
        static void Empilhar(int valor)
        {
            //Cria um novo nó com valor fornecido
            Node novoNode = new Node { Valor = valor, Proximo = topo };
            //Atualiza o topo do Nó
            topo = novoNode;
        }

        //Desempilha e remove o elemento do topo da pilha
        static void Desempilhar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }

            System.Console.WriteLine($"Elemento removido: {topo.Valor}");
            topo = topo.Proximo;
        }

        static void Listar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }

            System.Console.WriteLine("Listando a pilha: ");
            Node? atual = topo;
            while (atual != null)
            {
                System.Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }

        // Função principal para execução do programa
        static void Main()
        {
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            Listar();
            Desempilhar();
            Listar();
        }
    }
}