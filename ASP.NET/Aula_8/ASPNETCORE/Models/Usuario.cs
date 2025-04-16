using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETCORE.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        [Column("id_usuario")]
        public int Id { get; set; } // <-- Renomeie de "Id_Usuario" para "Id"

        [Column("nome_usuario")]
        public string Nome { get; set; } = string.Empty;

        [Column("password")]
        public string Senha { get; set; } = string.Empty; // <-- Altere para "Senha" se quiser

        [Column("ramal")]
        public int Ramal { get; set; }

        [Column("especialidade")]
        public string Especialidade { get; set; } = string.Empty;
    }
}
