using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio
{
    public class Sala
    {
        // Propriedades do Quarto
        public PortaSala PortaSala { get; set; }
        public Porta PortaAuxiliar { get; set; }
        public float MetragemQuadrada { get; set; }

        //Construtor vai ter uma relação de composição com o PortaQuarto
        public Sala(PortaSala portaSala, Porta portaAuxiliar, float metragemquadrada)
        {
            PortaAuxiliar = portaAuxiliar;
            MetragemQuadrada = metragemquadrada;
            // Relação de composição
            PortaSala = new PortaSala("Branca", 2.80f, 4.10f, 15.0);
        }

        // Método utilizando a porta da sala auxiliar
        public void AbrirPortaAuxiliar()
        {
            // Fazendo uma associação simples da classe Porta
            PortaAuxiliar.Abrir();
        }
    }
}