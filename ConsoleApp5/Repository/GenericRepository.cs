using ConsoleApp5.Contracts;
using ConsoleApp5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IdentityDBContext _context;

        public GenericRepository(IdentityDBContext context)
        {
            this._context = context;
        }
        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var item = _context.Set<T>().Find(id);
            return item;
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
