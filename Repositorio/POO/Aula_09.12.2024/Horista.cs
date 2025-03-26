using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public class Horista : Empregado
    {
        public double precoHora;
        public double horasTrabalhadas;

        public Horista(string nome, string sobrenome, string cpf, double precohora, double horastrabalhadas) : base(nome, sobrenome, cpf)
        {
            this.precoHora = precohora;
            this.horasTrabalhadas = horastrabalhadas;
        }

        public override double Vencimento()
        {
            return precoHora * horasTrabalhadas;
        }

        public override void imprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Sobrenome:" + sobreNome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Preço Hora: " + precoHora);
            System.Console.WriteLine("Horas Trabalhadas: " + horasTrabalhadas);
            System.Console.WriteLine("Total valor de horas: \n" + Vencimento());
        }
    }
}