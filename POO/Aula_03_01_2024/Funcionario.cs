using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_03_01_2024
{
    public abstract class Funcionario : IRelatorio
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public int CPF { get; set; }
        public double SalarioBase { get; set; }

        //Aqui a composição vai acontecer lá na classe Executar
        public abstract double CalcularSalario();

        public abstract void GerarRelatorio();
    }

    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase * 1.2;
        }

        public void CalcularGratificacao()
        {
            System.Console.WriteLine("Calculando gratificação...");
        }

        public override void GerarRelatorio()
        {
            System.Console.WriteLine("Gerando relatório de gerente...");
            System.Console.WriteLine("Gerente: " + Nome);
            System.Console.WriteLine("Salário: " + CalcularSalario());
        }
    }

    public class Vendedor : Funcionario
    {
        public double VendasRealizadas { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase + (VendasRealizadas * 0.1);
        }

        public void CalcularBonus()
        {
            System.Console.WriteLine("Calculando bonus...");
        }

        public override void GerarRelatorio()
        {
            System.Console.WriteLine("Gerando relatório de vendedor...");
            System.Console.WriteLine("Vendedor: " + Nome);
            System.Console.WriteLine("Salário: " + CalcularSalario());
        }
    }

    public class Padeiro : Funcionario
    {
        public double HorasNoturnas { get; set; }

        public override double CalcularSalario()
        {
            double adicionalNoturno = HorasNoturnas * (SalarioBase * 0.25 / 160);
            return SalarioBase + adicionalNoturno;
        }

        public override void GerarRelatorio()
        {
            System.Console.WriteLine("Gerando relatório de padeiro...");
            System.Console.WriteLine("Padeiro: " + Nome);
            System.Console.WriteLine("Salário: " + CalcularSalario());
        }
    }
}