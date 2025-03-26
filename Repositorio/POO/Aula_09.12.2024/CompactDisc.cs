using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_12_2024
{
    public class CompactDisc : Produto
    {
        public string Artista;
        public string Gravadora;

        public CompactDisc(string artista, string gravadora, int codigo, double preco) : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }

        public string getGravadora()
        {
            return Gravadora;
        }

        public string getArtista()
        {
            return Artista;
        }

        public void setGravadora(string gravadora)
        {
            Gravadora = gravadora;
        }

        public void setArtista(string artista)
        {
            Artista = artista;
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