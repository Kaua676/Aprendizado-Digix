using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio
{
    public class Porta
    {
        // Propriedade
        // Se quiser fazer de forma extensa: "private string _cor"
        // Ai faz os metodos get e set
        public string Cor { get; set; }
        public float Largura { get; set; }
        public float Altura { get; set; }
        public double Peso { get; set; }

        // Construtor
        public Porta(string cor, float largura, float altura, double peso)
        {
            Cor = cor;
            Largura = largura;
            Altura = altura;
            Peso = peso;
        }

        // Métodos que serão herdados
        public virtual void Abrir()
        {
            System.Console.WriteLine("Porta Aberta");
        }

        public virtual void Fechar()
        {
            System.Console.WriteLine("Porta Fechada");
        }
    }
}