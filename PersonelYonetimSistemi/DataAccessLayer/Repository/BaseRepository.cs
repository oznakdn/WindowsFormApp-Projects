using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Repository
{
    public class BaseRepository<TEntity>:IRepository<TEntity> where TEntity:class,new()
    {
       
        // contructor'da context nesnesini türetiyoruz
        PersonelSistemiDbContext dbContext;
        public BaseRepository()
        {
            dbContext = new PersonelSistemiDbContext();
        }

        public void AddorUpdate(TEntity entity)
        {
            dbContext.Set<TEntity>().AddOrUpdate(entity);
        }

        public void Delete(Expression<Func<TEntity,bool>>Filter)
        {
           var query= dbContext.Set<TEntity>().FirstOrDefault(Filter);
            dbContext.Set<TEntity>().Remove(query);

        }
        public TEntity GetByFilter(Expression<Func<TEntity, bool>> Filter)
        {
            return dbContext.Set<TEntity>().FirstOrDefault(Filter);

        }

        public List<TEntity> GetList(Expression<Func<TEntity,bool>>Filter=null)
        {
            return Filter == null ? dbContext.Set<TEntity>().ToList() : dbContext.Set<TEntity>().Where(Filter).ToList();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        // Ekle ve Güncelle metodu
        //public void AddorUpdate(TEntity entity)
        //{
        //    dbContext.Set<TEntity>().AddOrUpdate(entity);
        //}

        //// Sil Metodu
        //public void Delete(Expression<Func<TEntity, bool>> Filter) //Id ye göre sileceğinden filter zorunlu
        //{
        //    var query = dbContext.Set<TEntity>().FirstOrDefault(Filter);
        //    dbContext.Set<TEntity>().Remove(query);

        //}

        //// Kaydet Metodu
        //public void Save()
        //{
        //    dbContext.SaveChanges();
        //}

        //// Listele Metodu
        //public List<TEntity> GetList(Expression<Func<TEntity, bool>> Filter = null) // filter zorunlu değil
        //{
        //    List<TEntity> Liste;
        //    if (Filter == null) Liste = dbContext.Set<TEntity>().ToList();
        //    else Liste = dbContext.Set<TEntity>().Where(Filter).ToList();
        //    return Liste;
        //}

        //// Filtreye göre getir metodu
        //public TEntity GetByFilter(Expression<Func<TEntity, bool>> Filter) // filter zorunlu
        //{
        //    return dbContext.Set<TEntity>().FirstOrDefault(Filter);

        //}


    }
}
