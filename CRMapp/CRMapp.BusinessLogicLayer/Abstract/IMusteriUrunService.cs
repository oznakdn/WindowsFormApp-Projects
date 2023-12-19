using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CRMapp.Model;
namespace CRMapp.BusinessLogicLayer.Abstract
{
    public interface IMusteriUrunService
    {
        void Add(MusteriUrun entity);
        void Update(MusteriUrun entity);
        void Delete(int id);
        List<MusteriUrun> GetAll(Expression<Func<MusteriUrun, bool>> Filter = null);
        MusteriUrun GetByFilter(Expression<Func<MusteriUrun, bool>> Filter);
    }
}
