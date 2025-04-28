using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Escolar.Models
{
    public class DisciplinaAlunoCurso
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public int CursoId { get; set; }
        public int DisciplinaId { get; set; }
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}