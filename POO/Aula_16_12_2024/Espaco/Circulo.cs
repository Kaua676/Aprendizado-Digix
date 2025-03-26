using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024
{
    public class Circulo : IForma
    {
        // Propriedade Raio
        public double Raio { get; set; }

        //Construtor
        public Circulo(double raio)
        {
            Raio = raio;
        }

        // Implementação do método CalcularArea
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
        // Implementação do método CalcularPerimetro
        public double CalcularPerimentro()
        {
            return 2 * Math.PI * Raio;
        }
        
        public void ExibirInformacoes()
        {
            System.Console.WriteLine("Circulo");
            System.Console.WriteLine("Raio: " + Raio);
        }
    }
}