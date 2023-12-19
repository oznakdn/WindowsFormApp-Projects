using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CRMapp.Model;

namespace CRMapp.BusinessLogicLayer.Abstract
{
    public interface IMusteriService
    {
        void Add(Musteri entity);
        void Update(Musteri entity);
        void Delete(int id);
        List<Musteri> GetAll(Expression<Func<Musteri, bool>> Filter = null);
        Musteri GetByFilter(Expression<Func<Musteri, bool>> Filter);
    }
}
