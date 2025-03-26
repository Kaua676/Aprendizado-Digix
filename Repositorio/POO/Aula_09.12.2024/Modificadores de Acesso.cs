using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public class Funcionario
    {
        //Atributos publicos: acessivel de qualquer lugar
        public string Nome;
        //Atributo privado: acessivel apenas dentro da classe
        private double Salario;
        //Atributo protegido: acessivel apenas dentro da clase e suas subclasses
        protected string Cargo;

        //Construtor
        public Funcionario(string nome, double salario, string cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        //Metodo publico
        public void exibirInformacoes()
        {
            System.Console.WriteLine("Nome: " + Nome);
            // System.Console.WriteLine("Salario: " + Salario); // * Acessando tributo privado * // 
            System.Console.WriteLine("Cargo: " + Cargo);
        }

        //Metodo protegido
        protected void atualizarCargo(string novoCargo)
        {
            Cargo = novoCargo;
            System.Console.WriteLine("Cargo atualizado para: " + Cargo);
        }

        //Metodo privado
        private double calcularImposto()
        {
            return Salario * 0.1;
        }
    }
}