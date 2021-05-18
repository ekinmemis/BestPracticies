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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Categories> GetCategoryById(int categoryId)
        {
            return new SuccessDataResult<Categories>(_categoryDal.Where(p => p.CategoryID == categoryId));
        }

        public IDataResult<List<Categories>> GetAll()
        {
            return new SuccessDataResult<List<Categories>>(_categoryDal.GetAll().ToList());
        }

        public IDataResult<List<Categories>> GetCategoriesByProductId(int categoryId)
        {
            return new SuccessDataResult<List<Categories>>(_categoryDal.GetAll(p => p.CategoryID == categoryId).ToList());
        }

        public IResult Insert(Categories category)
        {
            _categoryDal.Insert(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Categories category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IResult Update(Categories category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IDataResult<Categories> Where(Expression<Func<Categories, bool>> predicate)
        {
            return new SuccessDataResult<Categories>(_categoryDal.Where(predicate));
        }
    }
}