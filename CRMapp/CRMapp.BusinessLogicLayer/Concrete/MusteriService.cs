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
    public class MusteriService : IMusteriService
    {
        IMusteriRepository repository;
        public MusteriService(IMusteriRepository _repository)
        {
            repository = _repository;
        }

        public void Add(Musteri entity)
        {
            repository.Add(entity);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<Musteri> GetAll(Expression<Func<Musteri, bool>> Filter = null)
        {
            return repository.GetAll(Filter);
        }

        public Musteri GetByFilter(Expression<Func<Musteri, bool>> Filter)
        {
            return repository.GetByFilter(Filter);
        }

        public void Update(Musteri entity)
        {
            repository.Update(entity);
        }
    }
}
