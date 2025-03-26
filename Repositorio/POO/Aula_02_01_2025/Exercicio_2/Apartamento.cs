using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public class Apartamento
    {
        public string Proprietario { get; set; }
        public double Area { get; set; }
        public int Quartos { get; set; }
        public int Banheiros { get; set; }

        public Apartamento(string proprietario, double area, int quartos, int banheiros)
        {
            Proprietario = proprietario;
            Area = area;
            Quartos = quartos;
            Banheiros = banheiros;
        }

        public string DescricaoDoApartamento()
        {
            return $"Propriedade de {Proprietario}.\nPossui {Area}m², {Quartos} quartos, {Banheiros} banheiros.";
        }
    }
}