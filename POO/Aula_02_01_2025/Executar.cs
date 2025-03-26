using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_02_01_2025.Exercicio_3;
using Aula_02_01_2025.Exercicio_1;
using Aula_02_01_2025.Exercicio_2;

namespace Aula_02_01_2025
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Exercicio 1
            Animalia homoSapiens = new HomoSapiens();
            Animalia canisFamiliaris = new CanisFamiliaris();
            Animalia muscaDomestica = new MuscaDomestica();

            Console.WriteLine("Descrição do Homo sapiens:");
            Console.WriteLine(homoSapiens.ObterDescricao());
            Console.WriteLine();

            Console.WriteLine("Descrição do Canis familiaris:");
            Console.WriteLine(canisFamiliaris.ObterDescricao());
            Console.WriteLine();

            Console.WriteLine("Descrição do Musca domestica:");
            Console.WriteLine(muscaDomestica.ObterDescricao());

            // Exercicio 2
            System.Console.WriteLine("----------------------------------------------------------------");
            Engenheiro engenheiro = new Engenheiro("Astolfo Pires", 123456);
            
            Predio predio = new Predio("Dom Quixote", 542, 4, 1000, "Av. Paulista, 123, São Paulo - SP", engenheiro);

            UnidadeResidencial unidade1 = new UnidadeResidencial(80, 3, 2, new Pessoa("Gilberto Macedo", "111.222.333-44"));
            UnidadeResidencial unidade2 = new UnidadeResidencial(80, 3, 2, new Pessoa("Bruna Ruas", "555.666.777-88"));
            UnidadeResidencial unidade3 = new UnidadeResidencial(80, 3, 2, new Pessoa("Vivian Bicalho", "999.000.111-22"));

            predio.CadastrarUnidade(unidade1);
            predio.CadastrarUnidade(unidade2);
            predio.CadastrarUnidade(unidade3);

            Console.WriteLine(predio.DescricaoDoImovel());

            // Exercicio 3
            System.Console.WriteLine("----------------------------------------------------------------");
            Veiculo caminhao = new Caminhao("ABC1234", "Caminhão Ford", 300.0, 4);
            Console.WriteLine($"Caminhão: {caminhao.Modelo}, Placa: {caminhao.Placa}, Diária: R${caminhao.CalcularDiaria():F2}");

            Veiculo carro = new Carro("DEF5678", "Carro Toyota", 150, "B");
            Console.WriteLine($"Carro: {carro.Modelo}, Placa: {carro.Placa}, Diária: R${carro.CalcularDiaria():F2}");

            Veiculo moto = new Moto("GHI9012", "Moto Honda", 50, 250);
            Console.WriteLine($"Moto: {moto.Modelo}, Placa: {moto.Placa}, Diária: R${moto.CalcularDiaria():F2}");

            Utilitario utilitario = new Utilitario("UTIL123", "F-250", 100, 1500);
            Console.WriteLine($"Camionete: {utilitario.Modelo}, Placa: {utilitario.Placa}, Diária: R${utilitario.CalcularDiaria():F2}");
        }
    }
}
