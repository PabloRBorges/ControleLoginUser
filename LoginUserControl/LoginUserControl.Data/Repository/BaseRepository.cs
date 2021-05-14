using LoginUserControl.Data.Context;
using LoginUserControl.Core.Entities;
using LoginUserControl.Core.Interfaces;
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

        protected readonly ModelContext _sqlContext;

        public BaseRepository(ModelContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Delete(Guid id)
        {
            _sqlContext.Set<TEntity>().Remove(Select(id));
            _sqlContext.SaveChanges();
        }

        public void Insert(TEntity obj)
        {
            _sqlContext.Set<TEntity>().Add(obj);
            _sqlContext.SaveChanges();
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
