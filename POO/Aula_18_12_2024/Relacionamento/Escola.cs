using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aula_18_12_2024
{
    // 
    public class Escola
    {
        private Estudante estudante;

        private Professor professor;

        // Construtor da escola
        // Vai mostrar a relação de composição
        public Escola(string nomeEstudante)
        {
            estudante = new Estudante(nomeEstudante);
        }

        // Método de agregação (que recebe de forma externa o professor)
        public void ContratarProfessor(Professor professor)
        {
            this.professor = professor;
        }

        // Mostrar informações
        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome do aluno: {estudante.Nome}");
            System.Console.WriteLine($"Nome do professor: {professor.Nome}");
            professor.Ensinar();
        }
    }
}