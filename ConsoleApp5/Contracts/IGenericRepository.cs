using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Contracts
{
    public interface IGenericRepository <T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
