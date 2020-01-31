using System.Collections.Generic;
using HolidaySlug.Data.Context;
using HolidaySlug.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HolidaySlug.Data.Repositories.Implementations
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private HolidaySlugContext _context = null;
        private DbSet<T> _table = null;

        public BaseRepository(HolidaySlugContext context)
        {
            this._context = context;
            _table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}