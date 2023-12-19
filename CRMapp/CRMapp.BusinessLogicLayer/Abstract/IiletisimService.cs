using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CRMapp.Model;
namespace CRMapp.BusinessLogicLayer.Abstract
{
    public interface IiletisimService
    {
        void Add(iletisim entity);
        void Update(iletisim entity);
        void Delete(int id);
        List<iletisim> GetAll(Expression<Func<iletisim, bool>> Filter = null);
        iletisim GetByFilter(Expression<Func<iletisim, bool>> Filter);
    }
}
