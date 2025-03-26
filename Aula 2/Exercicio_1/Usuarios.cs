using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exercicio_1
{
    [Table("usuarios")] // Define explicitamente o nome da tabela
    public class Usuarios
    {
        [Key]
        [Column("id_usuario")]
        public int Id_Usuario { get; set; }

        [Column("password")]
        public string Password { get; set; } = string.Empty;

        [Column("nome_usuario")]
        public string Nome_Usuario { get; set; } = string.Empty;

        [Column("ramal")]
        public int Ramal { get; set; }

        [Column("especialidade")]
        public string Especialidade { get; set; } = string.Empty;
    }
}
