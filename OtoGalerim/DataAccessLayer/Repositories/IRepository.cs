using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IRepository<T> where T:class,new()
    {
        void AddorUpdate(T entity);
        void Delete(Expression<Func<T, bool>> Filter);
        void Save();
        T GetbyFilter(Expression<Func<T, bool>> Filter);
        List<T> GetAll(Expression<Func<T, bool>> Filter = null);
    }
}
