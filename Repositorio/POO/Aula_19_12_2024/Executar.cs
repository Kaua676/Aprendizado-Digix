using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_12_2024
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Criando Leitores e Funcionários
            Leitor leitor1 = new Leitor("João", "12345678901");
            Funcionario funcionario1 = new Funcionario("Maria", "98765432100", "Bibliotecário");

            // Criando Biblioteca e Catálogo
            Biblioteca biblioteca = new Biblioteca("Biblioteca Central");
            biblioteca.AdicionarFuncionario(funcionario1);

            // Adicionando livros ao catálogo
            Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 5);
            Livro livro2 = new Livro("1984", "George Orwell", 1949, 3);
            biblioteca.Catalogo.AdicionarLivro(livro1);
            biblioteca.Catalogo.AdicionarLivro(livro2);

            // Criando Rede de Bibliotecas e adicionando a biblioteca
            RedeDeBibliotecas rede = new RedeDeBibliotecas();
            rede.AdicionarBiblioteca(biblioteca);

            // Consultando livros na biblioteca
            biblioteca.ConsultarLivros();

            // Leitor pegando livro emprestado
            leitor1.PegarEmprestado(livro1);

            // Funcionário realizando empréstimo
            funcionario1.RealizarEmprestimo(livro2, leitor1);
        }
    }
}