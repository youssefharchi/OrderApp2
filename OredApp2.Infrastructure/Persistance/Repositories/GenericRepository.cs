using Microsoft.EntityFrameworkCore;
using OrderApp2.Core.Application.Interfaces;
using OredApp2.Infrastructure.Persistance.DBContext;

namespace OredApp2.Infrastructure.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> table;

        public GenericRepository(DataContext context)
        {
            _context = context;
            table = context.Set<T>();
        }

        public bool Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            return Save();
        }

        public bool Exists(object id)
        {
            return table.Find(id) != null;
        }

        public IQueryable<T> GetAll()
        {
            return table;
        }

        public T? GetById(object id)
        {
            return table.Find(id);
        }

        public bool Insert(T obj)
        {
            table.Add(obj);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            return Save();
        }
    }
}