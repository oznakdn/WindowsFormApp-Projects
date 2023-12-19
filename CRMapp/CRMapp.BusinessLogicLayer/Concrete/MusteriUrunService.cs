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
    public class MusteriUrunService : IMusteriUrunService
    {
        IMusteriUrunRepository repository;
        public MusteriUrunService(IMusteriUrunRepository _repository)
        {
            repository = _repository;
        }

        public void Add(MusteriUrun entity)
        {
            repository.Add(entity);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<MusteriUrun> GetAll(Expression<Func<MusteriUrun, bool>> Filter = null)
        {
            return repository.GetAll(Filter);
        }

        public MusteriUrun GetByFilter(Expression<Func<MusteriUrun, bool>> Filter)
        {
            return repository.GetByFilter(Filter);
        }

        public void Update(MusteriUrun entity)
        {
            repository.Update(entity);
        }
    }
}
