using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public class Circulo : Forma
    {
        public double Raio;

        public Circulo(string nome, double raio) : base(nome)
        {
            Raio = raio;
        }

        public override double calcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double calcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        // public override void imprimirDados()
        // {
        //     System.Console.WriteLine("Nome: " + Nome);
        //     System.Console.WriteLine("Raio: " + Raio);
        //     System.Console.WriteLine("Area: " + calcularArea());
        //     System.Console.WriteLine("Perimetro: " + calcularPerimetro());
        // }

        //Outra forma de imprimirDados
        public override void imprimirDados()
        {
            base.imprimirDados();
            System.Console.WriteLine("Raio: " + Raio);
        }
    }
}