using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Basic.Core.Utilities.Results;
using Basic.Entities.Concrete;

namespace Basic.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Products> Where(Expression<Func<Products, bool>> predicate);

        IDataResult<Products> GetProductById(int id);

        IDataResult<List<Products>> GetAll();

        IDataResult<List<Products>> GetProductsByCategoryId(int categoryId);

        IResult Insert(Products product);

        IResult Update(Products product);

        IResult Delete(Products product);
    }
}