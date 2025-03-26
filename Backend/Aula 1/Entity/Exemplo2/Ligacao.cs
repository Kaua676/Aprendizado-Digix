using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Exemplo2
{
    public class Ligacao : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; } // Define a tabela a ser utilizada

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=root;Database=Aula 1;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("pessoa");
        }
    }
}