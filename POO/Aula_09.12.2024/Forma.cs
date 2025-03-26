using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public abstract class Forma
    {
        public string Nome;
        public Forma(string nome)
        {
            Nome = nome;
        }

        //Metodos abstratos nao possuem corpo e devem ser implementado nas classes filhas
        public abstract double calcularArea();

        public abstract double calcularPerimetro();

        public virtual void imprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Area:" + calcularArea());
            System.Console.WriteLine("Perimetro: " + calcularPerimetro());
        }
    }
}