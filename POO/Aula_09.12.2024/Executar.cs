using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // --------------------------------------------------------------------------------------------
            //Só poderá ser instanciado as classes filhas
            // Circulo circulo = new Circulo("Circulo", 5);
            // circulo.calcularArea();
            // circulo.calcularPerimetro();
            // circulo.imprimirDados();

            // Retangulo retangulo = new Retangulo("Retangulo", 5, 10);
            // circulo.calcularArea();
            // circulo.calcularPerimetro();
            // circulo.imprimirDados();

            // --------------------------------------------------------------------------------------------
            // Assalariado assalariado = new Assalariado("João", "da Silva", "123.456.789-00", 1420);
            // assalariado.Vencimento();
            // assalariado.imprimirDados();

            // Comissionado comissionado = new Comissionado("Kauã", "Vicente", "123.456.789-00", 300, 0.5);
            // comissionado.Vencimento();
            // comissionado.imprimirDados();

            // Horista horista = new Horista("Kleber", "Nascimento", "123.456.789-00", 50, 100);
            // horista.Vencimento();
            // horista.imprimirDados();
            // --------------------------------------------------------------------------------------------
            // Produto[] produtos = new Produto[3];
            // produtos[0] = new Livro("Autor 1", 1, 123456789, 35.0);
            // produtos[1] = new Livro("Autor 2", 2, 123456789, 80.0);
            // produtos[2] = new Livro("Autor 3", 3, 123456789, 20.0);

            // foreach (Produto produto in produtos)
            // {
            //     System.Console.WriteLine("Codigo" + produto.getCodigo());
            //     System.Console.WriteLine("Preço: " + produto.getPreco());
            //     produto.atualizaPreco(produto.getPreco() * 1.1);
            //     System.Console.WriteLine("Preço atualizado: " + produto.getPreco());
            //     System.Console.WriteLine();
            // }
            // --------------------------------------------------------------------------------------------
            //Instanciar o objeto funcionario
            Funcionario funcionario = new Funcionario("Joao", 2000, "Analista");
            System.Console.WriteLine("Funcionario: " + funcionario.Nome);
            funcionario.Nome = "Vitor";
            System.Console.WriteLine("Funcionario: " + funcionario.Nome);
            // System.Console.WriteLine("Salario: " + funcionario.Salario);
            // funcionario.Salario = 3000;
            // funcionario.Cargo = "Gerente";
            
            //Instanciar o objeto gerente
            Gerente gerente = new Gerente("Maria", 5000);
            System.Console.WriteLine("Gerente: " + gerente.Nome);
            gerente.Nome = "Fabiana";
            System.Console.WriteLine("Gerente: " + gerente.Nome);
            gerente.atualizarCargoGerente("Diretor");

            //Instanciar o objeto salario
        }
    }
}