using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024.Relacoes.Agregacao
{
    public class Professor
    {
        public string Nome;

        public Professor(string nome)
        {
            Nome = nome;
        }

        public void Ensinar()
        {
            System.Console.WriteLine("Professor: " + Nome);
        }
    }
}