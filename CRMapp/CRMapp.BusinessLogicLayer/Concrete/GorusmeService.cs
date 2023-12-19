using CRMapp.BusinessLogicLayer.Abstract;
using CRMapp.DataAccessLayer.Abstract;
using CRMapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.BusinessLogicLayer.Concrete
{
    public class GorusmeService : IGorusmeService
    {
        IGorusmeRepository repository;
        public GorusmeService(IGorusmeRepository _repository)
        {
            repository = _repository;
        }

        public void Add(Gorusme entity)
        {
            repository.Add(entity);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<Gorusme> GetAll(Expression<Func<Gorusme, bool>> Filter = null)
        {
            return repository.GetAll(Filter);
        }

        public Gorusme GetByFilter(Expression<Func<Gorusme, bool>> Filter)
        {
            return repository.GetByFilter(Filter);
        }

        public void Update(Gorusme entity)
        {
            repository.Update(entity);
        }
    }
}
