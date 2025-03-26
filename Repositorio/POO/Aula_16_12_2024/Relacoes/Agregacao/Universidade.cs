using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024.Relacoes.Agregacao
{
    public class Universidade
    {
        public Professor professor;

        public Universidade(Professor professor)
        {
            this.professor = professor;
        }

        public void realizarAula()
        {
            System.Console.WriteLine("Realizando aula...");
            professor.Ensinar();
        }
    }
}