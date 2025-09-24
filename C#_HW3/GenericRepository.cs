using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW3
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly List<T> li;
        public GenericRepository()
        {
            li = new List<T>();
        }
        public void Add(T item)
        {
            li.Add(item);
        }
        public void Remove(T item)
        {
            li.Remove(item);
        }
        public void Save() { }
        public IEnumerable<T> GetAll()
        {
            return li;
        }
        public T GetById(int id)
        {
            if (id < 0 || id >= li.Count) { 
                throw new ArgumentOutOfRangeException($"Id {id} is not valid."); 
            }
            return li[id];
        }
    }
}
