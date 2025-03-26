using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_12_2024
{
    public class Petiscos
    {
        public string Nome;

        public double Preco;

        public int Quantidade;

        public Petiscos()
        {
            Nome = "Amendoim";
            Preco = 0.0;
            Quantidade = 10;

            //Se instanciar
            //Pestiscos p = new Pestiscos();
            //p.Nome = "Amendoim";
        }

        public Petiscos(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

            // Se instanciar
            // Petiscos p = new Petiscos("Amendoim", 3.00, 10);
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