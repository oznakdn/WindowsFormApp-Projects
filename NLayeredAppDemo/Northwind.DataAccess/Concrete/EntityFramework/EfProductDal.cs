using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Northwind.DataAccess.Abstract;
using System.Linq.Expressions;
using Northwind.DataAccess.Concrete.EntityFramework;

namespace Northwind.DataAccess.Concrete
{
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        
    }
}
