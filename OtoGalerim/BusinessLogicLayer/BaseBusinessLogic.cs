using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer
{
    public class BaseBusinessLogic<TEntity> where TEntity:class,new()
    {
        BaseRepository<TEntity> baseRepo;
        public BaseBusinessLogic()
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

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> Filter = null)
        {
            return baseRepo.GetAll(Filter);
        }

        public TEntity GetbyFilter(Expression<Func<TEntity, bool>> Filter)
        {
            return baseRepo.GetbyFilter(Filter);
        }

    }
}
