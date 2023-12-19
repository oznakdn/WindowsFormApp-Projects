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
    public class iletisimService : IiletisimService
    {
        IiletisimRepository repository;
        public iletisimService(IiletisimRepository _repository)
        {
            repository = _repository;
        }

        public void Add(iletisim entity)
        {
            repository.Add(entity);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<iletisim> GetAll(Expression<Func<iletisim, bool>> Filter = null)
        {
          return  repository.GetAll(Filter);
        }

        public iletisim GetByFilter(Expression<Func<iletisim, bool>> Filter)
        {
          return  repository.GetByFilter(Filter);
        }

        public void Update(iletisim entity)
        {
            repository.Update(entity);
        }
    }
}
