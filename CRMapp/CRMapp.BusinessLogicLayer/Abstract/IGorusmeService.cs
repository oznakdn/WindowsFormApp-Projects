using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CRMapp.Model;

namespace CRMapp.BusinessLogicLayer.Abstract
{
    public interface IGorusmeService
    {
        void Add(Gorusme entity);
        void Update(Gorusme entity);
        void Delete(int id);
        List<Gorusme> GetAll(Expression<Func<Gorusme, bool>> Filter = null);
        Gorusme GetByFilter(Expression<Func<Gorusme, bool>> Filter);
    }
}
