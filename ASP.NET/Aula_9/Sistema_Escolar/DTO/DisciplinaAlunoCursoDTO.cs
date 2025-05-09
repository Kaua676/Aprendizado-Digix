using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Escolar.Models;

// DTOs/DisciplinaAlunoCursoDTO.cs
namespace Sistema_Escolar.DTO
{
    // DTO de saída
    public class DisciplinaAlunoCursoDTO
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public string AlunoNome { get; set; } = null!;
        public int CursoId { get; set; }
        public string CursoDescricao { get; set; } = null!;
        public int DisciplinaId { get; set; }
        public string DisciplinaDescricao { get; set; } = null!;
    }

    // DTO de entrada para POST e PUT
    public class CreateDisciplinaAlunoCursoDTO
    {
        public int AlunoId { get; set; }
        public int CursoId { get; set; }
        public int DisciplinaId { get; set; }
    }
}
