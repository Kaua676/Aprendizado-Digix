using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exercicio_1
{
    [Table("maquina")]
    public class Maquina
    {
        [Key]
        [Column("id_maquina")]
        public int Id_Maquina { get; set; }

        [Column("tipo")]
        public string Tipo { get; set; } = string.Empty;

        [Column("velocidade")]
        public int Velocidade { get; set; }

        [Column("harddisk")]
        public int Hard_Disk { get; set; }

        [Column("placa_rede")]
        public int Placa_Rede { get; set; }

        [Column("memoria_ram")]
        public int Memoria_Ram { get; set; }

        [ForeignKey("usuarios")]
        [Column("fk_usuario")]
        public int Id_Usuario { get; set; }

    }
}