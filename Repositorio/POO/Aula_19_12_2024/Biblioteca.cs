using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_12_2024
{
    public class Biblioteca
    {
        public CatalogoDeLivros Catalogo { get; set; }
        public List<Funcionario> Funcionarios { get; set; }

        public Biblioteca(string nome)
        {
            Catalogo = new CatalogoDeLivros();
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void ConsultarLivros()
        {
            Catalogo.ConsultarLivros();
        }
    }
}