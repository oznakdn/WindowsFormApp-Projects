using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyFarmYS.DAL.Repositories
{
    public class BaseCrudRepository<TEntity> where TEntity:class,new()
    {
        MyFarmYSdbContext dbContext;
        public BaseCrudRepository()
        {
            dbContext = new MyFarmYSdbContext();

        }

        public void Ekle(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Added;
            dbContext.SaveChanges();
        }
        public void Guncelle(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void Sil(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Deleted;
            dbContext.SaveChanges();
        }
        public List<TEntity> HepsiniGetir()
        {
            return dbContext.Set<TEntity>().ToList();
        }

    }
}
