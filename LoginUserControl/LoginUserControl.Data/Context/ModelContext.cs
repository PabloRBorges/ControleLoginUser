using LoginUserControl.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace LoginUserControl.Data.Context
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {
        }


        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Bomba> Bombas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Placa> Placas { get; set; }
        public DbSet<DadoRecebido> DadosRecebidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contrato>()
            .Property(b => b.Id)
            .HasDefaultValueSql("(newid())");

            modelBuilder.Entity<Bomba>()
            .Property(b => b.Id)
             .HasDefaultValueSql("(newid())");

            modelBuilder.Entity<Cliente>()
            .Property(b => b.Id)
            .HasDefaultValueSql("(newid())");

            modelBuilder.Entity<Placa>()
            .Property(b => b.Id)
            .HasDefaultValueSql("(newid())");

            modelBuilder.Entity<DadoRecebido>()
            .Property(b => b.Id)
            .HasDefaultValueSql("(newid())");

            modelBuilder.Entity<Sensor>()
            .Property(b => b.Id)
            .HasDefaultValueSql("(newid())");
        }
    }
}
