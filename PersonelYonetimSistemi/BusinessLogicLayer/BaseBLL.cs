using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BaseBLL<TEntity> where TEntity : class, new()
    {
        BaseRepository<TEntity> baseRepo;
        public BaseBLL()
        {
            baseRepo = new BaseRepository<TEntity>();
        }

        public void AddorUpdate(TEntity entity)
        {
            baseRepo.AddorUpdate(entity);
        }

        public void Delete(Expression<Func<TEntity,bool>>Filter)
        {
            
            baseRepo.Delete(Filter);
        }

        public void Save()
        {
            baseRepo.Save();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> Filter=null)
        {
           
            return baseRepo.GetList(Filter);
        }

        public TEntity GetByFilter(Expression<Func<TEntity,bool>>Filter)
        {

            return baseRepo.GetByFilter(Filter);
        }


    }
}
