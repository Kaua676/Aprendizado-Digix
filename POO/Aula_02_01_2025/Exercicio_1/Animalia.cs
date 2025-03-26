using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_1
{
    public abstract class Animalia
    {
        public string Reino { get; } = "Animalia";
        public string Filo { get; }
        public string Classe { get; }
        public string Ordem { get; }
        public string Familia { get; }
        public string Genero { get; }
        public string Especie { get; }

        // Construtor
        public Animalia(string filo, string classe, string ordem, string familia, string genero, string especie)
        {
            Filo = filo;
            Classe = classe;
            Ordem = ordem;
            Familia = familia;
            Genero = genero;
            Especie = especie;
        }
        
        public abstract string ObterDescricao();
    }
}