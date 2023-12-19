using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        OtoGalerimContext dbContext;
        public BaseRepository()
        {
            dbContext = new OtoGalerimContext();
        }

        public void AddorUpdate(TEntity entity)
        {
            dbContext.Set<TEntity>().AddOrUpdate(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> Filter)
        {
            var query = dbContext.Set<TEntity>().FirstOrDefault(Filter);
            dbContext.Set<TEntity>().Remove(query);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> Filter = null)
        {
            return Filter == null ? dbContext.Set<TEntity>().ToList() : dbContext.Set<TEntity>().Where(Filter).ToList();
        }

        public TEntity GetbyFilter(Expression<Func<TEntity, bool>> Filter)
        {
            return dbContext.Set<TEntity>().FirstOrDefault(Filter);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
