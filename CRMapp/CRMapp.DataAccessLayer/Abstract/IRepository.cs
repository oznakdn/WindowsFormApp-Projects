using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.DataAccessLayer.Abstract
{
    public interface IRepository<T> where T:class,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll(Expression<Func<T, bool>> Filter = null);
        T GetByFilter(Expression<Func<T, bool>> Filter);
    }
}
