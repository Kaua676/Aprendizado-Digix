using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public class Livro : Produto
    {
        public string Autor;
        public long ISBN;

        public Livro(string autor, long isbn, int codigo, double preco) : base(codigo, preco)
        {
            Autor = autor;
            ISBN = isbn;
        }

        public string getAutor()
        {
            return Autor;
        }

        public long getISBN()
        {
            return ISBN;
        }

        public void setAutor(string autor)
        {
            Autor = autor;
        }

        public void setISBN(long isbn)
        {
            ISBN = isbn;
        }

        public override void setCodigo(int codigo)
        {
            Codigo = codigo;
        }

        public override void setPreco(double preco)
        {
            Preco = preco;
        }

        public override int getCodigo()
        {
            return Codigo;
        }

        public override double getPreco()
        {
            return Preco;
        }

        public override void atualizaPreco(double preco)
        {
            Preco = preco;
        }
    }
}