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
            return _table;
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