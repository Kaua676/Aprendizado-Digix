using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aula_18_12_2024
{
    // Classe estudante vai ser fundamental para a escola, etnão vai ter relação de composição
    public class Estudante
    {
        // Proriedades
        public string Nome {get; set;}

        // Construtor
        public Estudante (string nome)
        {
            Nome = nome;
        }

        // Função informar
        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome: {Nome}");
        }
    }
}