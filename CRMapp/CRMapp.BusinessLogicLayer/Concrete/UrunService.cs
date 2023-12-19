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
    public class UrunService : IUrunService
    {
        IUrunRepository urunRepository;
        public UrunService(IUrunRepository _urunRepository)
        {
            urunRepository = _urunRepository;
        }

        public void Add(Urun entity)
        {
            urunRepository.Add(entity);
        }

        public void Delete(int id)
        {
            urunRepository.Delete(id);
        }

        public List<Urun> GetAll(Expression<Func<Urun, bool>> Filter = null)
        {
            return urunRepository.GetAll(Filter);
        }

        public Urun GetByFilter(Expression<Func<Urun, bool>> Filter)
        {
            return urunRepository.GetByFilter(Filter);
        }

        public void Update(Urun entity)
        {
            urunRepository.Update(entity);
        }
    }
}
