using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_12_2024
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int ExemplaresDisponiveis { get; set; }

        public Livro(string titulo, string autor, int anoPublicacao, int exemplaresDisponiveis)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            ExemplaresDisponiveis = exemplaresDisponiveis;
        }
    }
}