using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Basic.Business.Abstract;
using Basic.Business.Constants;
using Basic.Core.Utilities.Results;
using Basic.DataAccess.Abstract;
using Basic.Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<Products> GetProductById(int productId)
        {
            return new SuccessDataResult<Products>(_productDal.Where(p => p.ProductID == productId));
        }

        public IDataResult<List<Products>> GetAll()
        {
            return new SuccessDataResult<List<Products>>(_productDal.GetAll().ToList());
        }

        public IDataResult<List<Products>> GetProductsByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Products>>(_productDal.GetAll(p => p.CategoryID == categoryId).ToList());
        }

        public IResult Insert(Products product)
        {
            _productDal.Insert(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Products product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IResult Update(Products product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<Products> Where(Expression<Func<Products, bool>> predicate)
        {
            return new SuccessDataResult<Products>(_productDal.Where(predicate));
        }
    }
}