using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HolidaySlug.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {

        IEnumerable<T> GetAll();

        IEnumerable<T> GetByWhere(Expression<Func<T,bool>> predicate);
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        void Save();

    }
}