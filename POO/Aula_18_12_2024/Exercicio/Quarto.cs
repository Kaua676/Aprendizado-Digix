using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio
{
    public class Quarto
    {
        // Propriedades do Quarto
        public PortaQuarto PortaQuarto { get; set; }
        public bool Banheiro { get; set; }
        public float MetragemQuadrada { get; set; }

        //Construtor vai ter uma relação de composição com o PortaQuarto
        public Quarto(bool banheiro, float metragemquadrada)
        {
            Banheiro = banheiro;
            MetragemQuadrada = metragemquadrada;
            PortaQuarto = new PortaQuarto("Branca", 0.80f, 2.10f, 10.0);
        }


    }
}