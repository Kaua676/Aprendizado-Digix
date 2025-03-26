using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio
{
    public class Cozinha
    {
        // Vou utilizar agregação com o objeto PortaCozinha
        // Propriedades
        public PortaCozinha PortaCozinha { get; set; }
        public bool Americana { get; set; }
        public float MetragemQuadrada { get; set; }

        // Como eu não vou instanciar a porta da cozinha no construtor ele pode ser relação de agregação
        // Construtor
        public Cozinha(bool americana, float metragemquadrada)
        {
            Americana = americana;
            MetragemQuadrada = metragemquadrada;
        }

        // Metodo entrou pela porta da cozinha
        public void Entrar(PortaCozinha portaCozinha)
        {
            // Aqui está ocorrendo a relação de agregação
            System.Console.WriteLine("Entrou pela porta da cozinha " + portaCozinha.Cor);
        }
    }
}