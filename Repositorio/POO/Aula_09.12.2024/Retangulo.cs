using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public class Retangulo : Forma
    {
        public double Largura;
        public double Altura;

        public Retangulo(string nome, double largura, double altura) : base(nome)
        {
            this.Largura = largura; // "This" é opcional porque esta apontando a um atirubuto da clase global
            this.Altura = altura;
        }

        public override double calcularArea()
        {
            return Largura * Altura;
        }

        public override double calcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public override void imprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Largura: " + Largura);
            System.Console.WriteLine("Altura: " + Altura);
            System.Console.WriteLine("Area: " + calcularArea());
            System.Console.WriteLine("Perimetro" + calcularPerimetro());
        }
    }
}