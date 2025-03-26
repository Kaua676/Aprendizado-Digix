using System;

namespace Padaria
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public Produto()
        {
            this.Nome = "Sem nome";
            this.Preco = 0;
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Nome: {this.Nome}");
            System.Console.WriteLine($"Preço: {this.Preco:C}"); //Exibe o preço como moeda brasileira
        }

        // static void Main(string[] args)
        // {
        //     // Produto produto = new Produto("Notebook", 2999.99);
        //     // produto.ExibirInformacoes();

        //     Produto produto2 = new Produto();
        //     produto2.Nome = "Mouse";
        //     produto2.Preco = 99.99;
        //     produto2.ExibirInformacoes();
        // }
    }
}
