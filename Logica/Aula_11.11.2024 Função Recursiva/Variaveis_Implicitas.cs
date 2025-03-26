using System;

namespace Funcoes_Avançadas
{
    public class Variaveis_Implicitas
    {

        static void Main(string[] args)
        {
            //Variavel implicita é uma variavel que pode receber qualquer tipo de variavel
            var nome = "C#";
            System.Console.WriteLine(nome);
            System.Console.WriteLine(nome.GetType());

            var idade = 20;
            System.Console.WriteLine(idade);
            System.Console.WriteLine(idade.GetType());

            var altura = 1.80;
            System.Console.WriteLine(altura);
            System.Console.WriteLine(altura.GetType());

            var ativo = true;
            System.Console.WriteLine(ativo);
            System.Console.WriteLine(ativo.GetType());

            //"Const", variavel que nao pode ser alterada, ou seja, nao pode ser reatribuida
            const string linguagem = "C#";
            System.Console.WriteLine(linguagem);
            System.Console.WriteLine(linguagem.GetType());

            const int anos = 20;
            System.Console.WriteLine(idade);
            System.Console.WriteLine(idade.GetType());

            const double tamanho = 1.80;
            System.Console.WriteLine(altura);
            System.Console.WriteLine(altura.GetType());

            const bool ifelse = true;
            System.Console.WriteLine(ativo);
            System.Console.WriteLine(ativo.GetType());

            //Lista
            var lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            System.Console.WriteLine(lista.GetType());
            //Função para listar os elementos da lista
            foreach (var item in lista)
            {
                System.Console.WriteLine(item);
            }

            //Dicionario
            var dicionario = new Dictionary<string, int> {
                { "Leepo", 1 },
                { "Ranquei", 2 },
                { "Vorta", 3 },
                { "Tufo", 4 },
                { "Cheeepo", 5 },
                { "É ruuuim", 6 },
                { "Cavuco", 7 }
                };
            System.Console.WriteLine(dicionario.GetType());

            //Função para listar os elementos do dicionario
            foreach (var item in dicionario)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
