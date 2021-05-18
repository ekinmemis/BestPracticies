using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Basic.Core.Entities;

namespace Basic.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Where(Expression<Func<T, bool>> filter);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}