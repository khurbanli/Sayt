﻿using System.Linq.Expressions;
using Core.Entities.Abstract;

namespace Core.DataAccess.Abstract
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
    }
}