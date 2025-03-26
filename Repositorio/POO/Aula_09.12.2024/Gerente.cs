using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public class Gerente : Funcionario
    {
        //Construtor
        public Gerente(string nome, double salario) : base(nome, salario, "Gerente")
        {

        }

        //Chamar o metodo publico
        public void Imprimir()
        {
            exibirInformacoes();
        }

        //Chamar o metodo protegido
        public void atualizarCargoGerente(string novoCargo)
        {
            atualizarCargo(novoCargo);
        }

        //Chamar o metodo privado
        public void calcularImpostoGerente()
        {
            // System.Console.WriteLine(calcularImposto());
        }
    }
}