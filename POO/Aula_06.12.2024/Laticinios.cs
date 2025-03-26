using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_12_2024
{
    public class Laticinios
    {
        public string Nome;

        public double Preco;

        public int Quantidade;

        public Laticinios()
        {
            Nome = "Leite";
            Preco = 0.0;
            Quantidade = 0;
        }

        public Laticinios(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public double CalcularEstoque()
        {
            return Preco * Quantidade;
        }

        public void ImprimirEstoque()
        {
            System.Console.WriteLine($"\nNome: {this.Nome}");
            System.Console.WriteLine($"Preço: {this.Preco:C}");
            System.Console.WriteLine($"Quantidade: {this.Quantidade}");
            System.Console.WriteLine($"Preço em Estoque: {CalcularEstoque()}\n");
        }
    }
}