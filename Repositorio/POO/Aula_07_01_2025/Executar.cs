using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07_01_2025
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Empregados listaEmpregados = new Empregados();

            Empregado vendedor = new Vendedor("João", 500);
            Empregado gerenteProducao = new GerenteProducao("Maria", RegiaoAtuacao.Norte);

            listaEmpregados.Insere(vendedor);
            listaEmpregados.Insere(gerenteProducao);

            listaEmpregados.Write("João");

            listaEmpregados.Read("Maria");

            double folhaPagamento = listaEmpregados.doFolhaPagamento();
            Console.WriteLine($"Folha de pagamento total: {folhaPagamento}");

            listaEmpregados.Imprime();

            GerenteProducao gerente = (GerenteProducao)gerenteProducao;
            gerente.AutorizaLicenca(vendedor);

            Console.WriteLine("\nApós alteração de licença:");
            listaEmpregados.Imprime();
        }
    }
}