using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo2
{
    [Table("pessoa")] // Define explicitamente o nome da tabela
    public class Usuario
    {
        [Column("id")]
        public int id { get; set; }

        [Column("nome")]
        public string nome { get; set; } = string.Empty;

        [Column("email")]
        public string email { get; set; } = string.Empty;
    }
}