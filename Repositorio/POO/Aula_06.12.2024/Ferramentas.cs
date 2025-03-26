using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_12_2024
{
    // public class Ferramentas{

    //Record é uma nova funcionalidade do c# que permite criar classes imutaveis que quer dizer que não podem ser alteradas após sua criação
    public record Ferramentas (string Nome, double Preco, int Quantidade) 
    {
        // public string Nome;

        // public double Preco;

        // public int Quantidade;

        // public Ferramentas()
        // {
        //     Nome = "Parafusadeira";
        //     Preco = 0.0;
        //     Quantidade = 0;
        // }

        // public Ferramentas(string nome, double preco, int quantidade)
        // {
        //     this.Nome = nome;
        //     this.Preco = preco;
        //     this.Quantidade = quantidade;
        // }

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