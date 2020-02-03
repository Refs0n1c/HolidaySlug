using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using HolidaySlug.Data.Context;
using HolidaySlug.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;

namespace HolidaySlug.Data.Repositories.Implementations
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected HolidaySlugContext _context;
        protected DbSet<T> _table;

        public BaseRepository(HolidaySlugContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _table;
        }

        public IEnumerable<T> GetByWhere(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            return _table.Find(id);
        }

        public void Insert(T obj)
        {
            _table.Add(obj);
        }

        public void Update(T obj)
        {
            _table.Update(obj);
        }

        public void Delete(T id)
        {
            _table.Remove(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}