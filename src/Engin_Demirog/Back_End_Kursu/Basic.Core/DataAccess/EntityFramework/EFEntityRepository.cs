using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Basic.Core.Entities;

using Microsoft.EntityFrameworkCore;

namespace Basic.Core.DataAccess.EntityFramework
{
    public class EFEntityRepository<T, TContext> : IEntityRepository<T>
        where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Insert(T entity)
        {
            using var context = new TContext();

            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new TContext();

            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public T Where(Expression<Func<T, bool>> filter)
        {
            using var context = new TContext();

            return context.Set<T>().SingleOrDefault(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using var context = new TContext();

            if (filter == null)
                return context.Set<T>().ToList();
            else
                return context.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            using var context = new TContext();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}