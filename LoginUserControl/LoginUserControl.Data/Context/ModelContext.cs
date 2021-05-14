using LoginUserControl.Core.Entities;
using Microsoft.EntityFrameworkCore;

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



    }
}
