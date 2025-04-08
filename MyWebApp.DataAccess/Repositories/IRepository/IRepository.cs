using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MyWebApp.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // Get all entities
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter);
        
        // Get entity by expression
        T Get(Expression<Func<T, bool>> filter);
        
        // Add entity
        void Add(T entity);
        
        // Remove entity
        void Remove(T entity);
        
        // Remove range of entities
        void RemoveRange(IEnumerable<T> entity);
    }
} 