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
    public class DepartmanService : IDepartmanService
    {
        IDepartmanRepository repository;
        public DepartmanService(IDepartmanRepository _repository)
        {
            repository = _repository;
        }

        public void Add(Departman entity)
        {
            repository.Add(entity);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<Departman> GetAll(Expression<Func<Departman, bool>> Filter = null)
        {
            return repository.GetAll(Filter);
        }

        public Departman GetByFilter(Expression<Func<Departman, bool>> Filter)
        {
            return repository.GetByFilter(Filter);
        }

        public void Update(Departman entity)
        {
            repository.Update(entity);
        }
    }
}
