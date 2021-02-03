using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _IProductDal;

        public ProductManager()
        {
        }

        public ProductManager(IProductDal iProductDal)
        {
            _IProductDal = iProductDal;
        }

        public List<Product> GetAll()
        {
            return _IProductDal.GetAll(); 
        }
    }


}
