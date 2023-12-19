using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CRMapp.Model;

namespace CRMapp.BusinessLogicLayer.Abstract
{
    public interface IUrunService
    {
        void Add(Urun entity);
        void Update(Urun entity);
        void Delete(int id);
        List<Urun> GetAll(Expression<Func<Urun, bool>> Filter = null);
        Urun GetByFilter(Expression<Func<Urun, bool>> Filter);
    }
}
