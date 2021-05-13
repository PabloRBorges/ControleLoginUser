using LoginUserControl.Data.Mapping;
using LoginUserControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoginUserControl.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }

        //private IDbConnection _dbConnection;
        //public DBContext(string connectionString)
        //{
        //    _dbConnection = new SqlConnection(connectionString);
        //}
        //public IDbConnection Connection => _dbConnection;
    }
}
