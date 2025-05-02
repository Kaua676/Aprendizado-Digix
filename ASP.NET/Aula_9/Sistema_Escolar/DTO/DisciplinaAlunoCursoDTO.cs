using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Escolar.Models;

namespace Sistema_Escolar.DTO
{
    public class DisciplinaAlunoCursoDTO
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public string AlunoNome { get; set; }
        public int CursoId { get; set; }
        public string CursoDescricao { get; set; }
        public int DisciplinaId { get; set; }
        public string DisciplinaDescricao { get; set; }
    }
}