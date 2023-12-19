using FluentValidation;
using Northwind.BusinessLogic.Abstract;
using Northwind.BusinessLogic.Utilities;
using Northwind.BusinessLogic.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BusinessLogic.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {

            //ValidationTool.Validate(new ProductValidator(),product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);

            }
            catch (DbUpdateException)
            {

                throw new Exception("Güncelleme Gerçekleşemedi");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();

        }

        public void Update(Product product)
        {
            //ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        List<Product> IProductService.GetByProductName(string productName)
        {
            return _productDal.GetAll(w => w.ProductName.ToLower().Contains(productName.ToLower()));

        }

        List<Product> IProductService.GetProductByCategory(int categoryId)
        {
            return _productDal.GetAll(w => w.CategoryID == categoryId).ToList();
        }
    }
}
