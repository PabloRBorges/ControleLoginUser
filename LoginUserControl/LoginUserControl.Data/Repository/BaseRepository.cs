using LoginUserControl.Data.Context;
using LoginUserControl.Domain.Entities;
using LoginUserControl.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUserControl.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {

        protected readonly SqlContext _sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Delete(Guid id)
        {
            _sqlContext.Set<TEntity>().Remove(Select(id));
        }

        public void Insert(TEntity obj)
        {
            _sqlContext.Set<TEntity>().Add(obj);
        }

        public IList<TEntity> Select() => _sqlContext.Set<TEntity>().ToList();

        public TEntity Select(Guid id) => _sqlContext.Set<TEntity>().Find(id);

        public void Update(TEntity obj)
        {
            _sqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlContext.SaveChanges();
        }
    }
}
