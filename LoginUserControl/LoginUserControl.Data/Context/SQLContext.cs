using LoginUserControl.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using LoginUserControl.Core.Models;
using Microsoft.Extensions.Options;
using IdentityServer4.EntityFramework.Options;

namespace LoginUserControl.Data.Context
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options,IOptions<OperationalStoreOptions> operationalStoreOptions) :
            base(options, operationalStoreOptions)
        {
        }



        //private IDbConnection _dbConnection;
        //public DBContext(string connectionString)
        //{
        //    _dbConnection = new SqlConnection(connectionString);
        //}
        //public IDbConnection Connection => _dbConnection;
    }
}
