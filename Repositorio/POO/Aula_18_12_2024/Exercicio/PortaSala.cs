using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio
{
    public class PortaSala : Porta
    {
        // Construtor
        public PortaSala(string cor, float largura, float altura, double peso) : base(cor, largura, altura, peso)
        {
        }

        // Sobreescrevendo o metodo abrir
        public override void Abrir()
        {
            System.Console.WriteLine("Porta da sala aberta");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Porta da sala fechada");
        }
    }
}