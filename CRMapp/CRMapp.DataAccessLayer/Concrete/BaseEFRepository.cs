using CRMapp.DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.DataAccessLayer.Concrete
{
    public class BaseEFRepository<TEntity, context> : IRepository<TEntity>
        where TEntity : class, new()
        where context : DbContext, new()
    {
      

        public void Add(TEntity entity)
        {
            using (CRMappContext dbcontext=new CRMappContext())
            {
                dbcontext.Set<TEntity>().Add(entity);
                dbcontext.SaveChanges(); 
            }
        }

        public void Delete(int id)
        {
            using (CRMappContext dbcontext = new CRMappContext())
            {
                var Id = dbcontext.Set<TEntity>().Find(id);
                dbcontext.Set<TEntity>().Remove(Id);
                dbcontext.SaveChanges(); 
            }
        }
        public void Update(TEntity entity)
        {
            using (CRMappContext dbcontext = new CRMappContext())
            {
                dbcontext.Set<TEntity>().Update(entity);
                dbcontext.SaveChanges(); 
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> Filter = null)
        {

            using (CRMappContext dbcontext = new CRMappContext())
            {
                return Filter == null ? dbcontext.Set<TEntity>().ToList() : dbcontext.Set<TEntity>().Where(Filter).ToList(); 
            }
        }

        public TEntity GetByFilter(Expression<Func<TEntity, bool>> Filter)
        {
            using (CRMappContext dbcontext = new CRMappContext())
            {
                return dbcontext.Set<TEntity>().FirstOrDefault(Filter); 
            }
        }

       
    }
}
