using LoginUserControl.Data.Mapping;
using LoginUserControl.Domain.Entities;
using LoginUserControl.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace LoginUserControl.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
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
