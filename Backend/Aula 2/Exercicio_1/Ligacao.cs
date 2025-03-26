using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_1
{
    public class Ligacao : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<Software> Softwares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=root;Database=Aula 2;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("usuarios");
            modelBuilder.Entity<Maquina>().ToTable("maquina");
            modelBuilder.Entity<Software>().ToTable("software");
        }
    }
}