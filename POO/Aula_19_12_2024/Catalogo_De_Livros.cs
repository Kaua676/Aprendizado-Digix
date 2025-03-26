using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_12_2024
{
    public class CatalogoDeLivros
    {
        public List<Livro> Livros { get; set; }

        public CatalogoDeLivros()
        {
            Livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void ConsultarLivros()
        {
            foreach (var livro in Livros)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.AnoPublicacao}, Exemplares: {livro.ExemplaresDisponiveis}");
            }
        }
    }
}