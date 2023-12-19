using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class, new()
    {
        void AddorUpdate(T entity);
        void Delete(Expression<Func<T,bool>>Filter);
        void Save();
        List<T> GetList(Expression<Func<T, bool>> Filter=null);
        T GetByFilter(Expression<Func<T, bool>> Filter);

    }
}
