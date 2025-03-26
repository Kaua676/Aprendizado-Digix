using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exercicio_1
{
    [Table("software")] // Define explicitamente o nome da tabela
    public class Software
    {
        [Key]
        [Column("id_software")]
        public int Id_Software { get; set; }

        [Column("produto")]
        public string Produto { get; set; } = string.Empty;

        [Column("harddisk")]
        public int Hard_Disk { get; set; }

        [Column("memoria_ram")]
        public int Memoria_Ram { get; set; }

        [ForeignKey("maquina")]
        [Column("fk_maquina")]
        public int Id_Maquina { get; set; }
    }
}
