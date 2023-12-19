using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CRMapp.Model;

namespace CRMapp.BusinessLogicLayer.Abstract
{
   public interface IDepartmanService
    {
        void Add(Departman entity);
        void Update(Departman entity);
        void Delete(int id);
        List<Departman> GetAll(Expression<Func<Departman, bool>> Filter = null);
        Departman GetByFilter(Expression<Func<Departman, bool>> Filter);
    }
}
