using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Escolar.DTO
{
    public class AlunoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Curso { get; set; } = null!;
    }
}