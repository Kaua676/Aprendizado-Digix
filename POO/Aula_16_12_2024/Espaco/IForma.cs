using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024
{
    public interface IForma
    {
        double CalcularArea();
        double CalcularPerimentro();

        // Esse tipo de implementação de declaração de função
        void ExibirInformacoes()
        {
            System.Console.WriteLine("Área: " + CalcularArea());
            System.Console.WriteLine("Perímetro: " + CalcularPerimentro());
        }
    }
}