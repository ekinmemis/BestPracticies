using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Basic.Core.Utilities.Results;
using Basic.Entities.Concrete;

namespace Basic.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Categories> Where(Expression<Func<Categories, bool>> predicate);

        IDataResult<Categories> GetCategoryById(int id);

        IDataResult<List<Categories>> GetAll();

        IDataResult<List<Categories>> GetCategoriesByProductId(int categoryId);

        IResult Insert(Categories category);

        IResult Update(Categories category);

        IResult Delete(Categories category);
    }
}