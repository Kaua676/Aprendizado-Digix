using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exemplo_Dapper
{
    // Atributo de mapeamento C#
    [Table("usuario")] // Define explicitamente o nome da tabela
    public class Usuario
    {
        // Ser chave primaria
        // [Key]
        // Se for chave estrangeira, usar [ForeignKey("nome_da_coluna")]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty; // Inicializando a variavel com string vazia

        [Column("email")]
        public string Email { get; set; } = string.Empty; // Inicializando a variavel com string vazia

        
    }
}