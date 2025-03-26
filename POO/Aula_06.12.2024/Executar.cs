using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_12_2024
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Carnes carnes = new Carnes("Coxão Mole", 39.99, 10);
            // Ferramentas ferramentas = new Ferramentas("Furadeira", 299.99, 5);
            // Petiscos petiscos = new Petiscos("Amendoim", 3.00, 25);
            // Limpeza limpeza = new Limpeza("Detergente", 2.69, 60);
            // Laticinios laticinios = new Laticinios("Iogurte", 2.99, 10);


            // carnes.ImprimirEstoque();
            // ferramentas.ImprimirEstoque();
            // petiscos.ImprimirEstoque();
            // limpeza.ImprimirEstoque();
            // laticinios.ImprimirEstoque();

            // // Maior valor do estoque
            // double maiorValor =
            //     Math.Max(carnes.CalcularEstoque(), 
            //     Math.Max(ferramentas.CalcularEstoque(),
            //     Math.Max(petiscos.CalcularEstoque(),
            //     Math.Max(limpeza.CalcularEstoque(), laticinios.CalcularEstoque()))));
            // System.Console.WriteLine($"Maior valor do estoque: {maiorValor:C}");


            // //Instanciando um objeto do tipo Gerente
            // Gerente gerente = new Gerente("João", "123.456.789-10", 5000, "TI");
            // System.Console.WriteLine("Mostrar o salario do gerente: " + gerente.Salario);
            // System.Console.WriteLine("Mostrar a bonificação do gerente: " + gerente.getBonificacao);
            // gerente.gerenciarEquipe();
            // gerente.Imprimir();

            // Secretaria secretaria = new Secretaria("Maria", "098.765.432-10", 1420, "3");
            // System.Console.WriteLine("Mostrar o salario da secretaria: " + secretaria.Salario);
            // System.Console.WriteLine("Mostrar a bonificação da secretaria: " + secretaria.getBonificacao);
            // secretaria.atenderTelefone();
            // secretaria.Imprimir();

            // Telefonista telefonista = new Telefonista("José", "044.763.412-10", 2200, "Portaria n°2");
            // System.Console.WriteLine("Mostrar o salario do telefonista: " + telefonista.Salario);
            // System.Console.WriteLine("Mostrar a bonificação do telefonista: " + telefonista.getBonificacao);
            // telefonista.atenderTelefone();
            // telefonista.Imprimir();

            Cobra cobra = new Cobra(true, false);
            cobra.Alimento("Rato");
            cobra.SetVenenosa(true);
            System.Console.WriteLine("-------------------");

            Javali javali = new Javali(true, true);
            javali.SetSelvagem(true);
            if (javali.SetSelvagem(true))
            {
                System.Console.WriteLine("O javali é selvagem");
            }
            else
            {
                System.Console.WriteLine("O javali não é selvagem");
            }
            System.Console.WriteLine($"A velocidade maximo do javali é {javali.GetVelocidadeMaxima()} km/h");

        }
    }
}