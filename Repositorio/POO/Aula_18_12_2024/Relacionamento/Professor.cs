using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024
{
    // Classe professor, vai ser agregada com a da escola, entoa vai ter relação de agregação
    public class Professor
    {
        // Proriedades
        public string Nome { get; set; }

        // Construtor
        public Professor(string nome)
        {
            Nome = nome;
        }

        // Método/Função ensinar
        public void Ensinar()
        {
            System.Console.WriteLine($"Professor: {Nome}");
        }
    }
}