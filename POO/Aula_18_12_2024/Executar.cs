using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_18_12_2024.Exercicio;
using Aula_18_12_2024.Exercicio2;

namespace Aula_18_12_2024
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // // Criar um objeto do tipo escola
            // Escola escola = new Escola("João");

            // // Criar um objeto do tipo professor
            // Professor professor = new Professor("Maria");

            // // Contratar o professor
            // escola.ContratarProfessor(professor);

            // // Mostrar informações
            // escola.MostrarInfo();

            // System.Console.WriteLine("Herança");
            // PortaCozinha portaCozinha = new PortaCozinha("Branca", 1.5f, 2.5f, 10);
            // portaCozinha.Abrir();
            // portaCozinha.Fechar();
            // System.Console.WriteLine($"Porta Cozinha: Cor: {portaCozinha.Cor}, Largura: {portaCozinha.Largura}, Altura: {portaCozinha.Altura}, Peso: {portaCozinha.Peso}");

            // System.Console.WriteLine("\nAgregação");
            // Cozinha cozinha = new Cozinha(true, 20);
            // cozinha.Entrar(portaCozinha);

            // Console.WriteLine("\nComposição");
            // PortaQuarto portaQuarto = new PortaQuarto("Marrom", 1.5f, 2.5f, 10);
            // Quarto quarto = new Quarto(true, 20);
            // Console.WriteLine($"quarto: {quarto.PortaQuarto.Cor}");

            // Console.WriteLine("\nAssociação simples");
            // PortaSala portaSala = new PortaSala("Azul", 1.5f, 2.5f, 10);
            // Sala sala = new Sala(portaSala, portaQuarto, 20);
            // sala.AbrirPortaAuxiliar();

            // Criando o estado
            Estado estado = new Estado("Mato Grosso do Sul", "MS");

            // Criando a cidade
            Cidade cidade = new Cidade("Campo Grande", estado);

            // Criando o endereço
            Endereco endereco = new Endereco("Rua Pitangui", 782, "Silvia Regina", "79103-151", cidade);

            // Criando a equipe de vendas
            EquipeVenda equipe = new EquipeVenda("Equipe Elite");

            // Criando o gerente
            Gerente gerente = new Gerente("Kauã", new DateTime(1985, 8, 15), "05448616127", endereco);

            // Criando o vendedor
            Vendedor vendedor = new Vendedor(equipe, "Maria", new DateTime(1990, 12, 20), "12345678900", endereco);

            // Exibindo informações do gerente
            Console.WriteLine("Informações do Gerente:");
            Console.WriteLine(gerente);
            Console.WriteLine($"Salário: R${gerente.getSalario():F2}");
            Console.WriteLine();

            // Exibindo informações do vendedor
            Console.WriteLine("Informações do Vendedor:");
            Console.WriteLine(vendedor);
            Console.WriteLine($"Salário: R${vendedor.getSalario():F2}");
            Console.WriteLine();

            // Exibindo a equipe de vendas
            Console.WriteLine("Equipe de Vendas:");
            Console.WriteLine(equipe);
        }
    }
}