using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Escolar.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public ICollection<DisciplinaAlunoCurso> DisciplinaAlunoCursos { get; set; }
    }
}