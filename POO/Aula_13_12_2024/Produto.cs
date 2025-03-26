using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_13_12_2024
{
    public class Produto
    {
        // private string _nome; //Convenção de nomenclatura do C#: _nome

        // Propriedade autoimplementada
        public string Nome { get; set; }

        private double _preco;

        private int _quantidade;

        //Construtor com 2 argumentos
        public Produto(string nome, double preco)
        {
            // _nome = nome;
            Nome = nome;
            _preco = preco;
        }

        //Reutilizando construtor dentro de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        //Encapsulamento, que o get (retornar) e set(alterar) de atributos privados
        // public string getNome()
        // {
        //     return _nome;
        // }

        // public void setNome(string nome)
        // {
        //     if (nome != null && nome.Length > 1)
        //     {
        //         _nome = nome;
        //     }
        // }

        // Agora vou utilizar a propriedade do C# para fazer o Get e Set
        // public string Nome
        // {
        //     get { return _nome; }
        //     set
        //     {
        //         if (value != null && value.Length > 1)
        //         {
        //             _nome = value; //O value é uma palavra reservada do C# que pega o valor que está sendo 
        //         }
        //     }
        // }

        // public double getPreco()
        // {
        //     return _preco;
        // }

        // public void double setPreco(double preco)
        // {
        //     if (preco > 0 && preco < 100000)
        //     {
        //         _preco = preco;
        //     }
        // }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0 && value < 100000)
                {
                    _preco = value;
                }
            }
        }

        public int getQuantidade()
        {
            return _quantidade;
        }

        public void setQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        // Função adicionar valor em estoque
        public void adicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void removerProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        // Função calcular o valor total em estoque
        public double totalEstoque()
        {
            return _preco * _quantidade;
            // get {return _preco * _quantidade;}
        }

        // Função TOstring
        public override string ToString()
        {
            return Nome + ", $ " + _preco.ToString("F2") + ", " + _quantidade + (" unidades, Total: $ "
            + totalEstoque().ToString("F2"));
        }
    }



















    
}