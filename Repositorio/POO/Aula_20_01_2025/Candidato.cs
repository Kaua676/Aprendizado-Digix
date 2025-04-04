using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public class Candidato
    {
        public string Nome { get; set; }
        public Voto Voto { get; set; }
        public ECargosEmDisputa Cargo { get; set; }
        public int NumeroIndentificador { get; set; }


        public Candidato(string nome, ECargosEmDisputa cargo, int numeroIndentificador)
        {
            Nome = nome;
            Cargo = cargo;
            NumeroIndentificador = numeroIndentificador;
        }
    }

}