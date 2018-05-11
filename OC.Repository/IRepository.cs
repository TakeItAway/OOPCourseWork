using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetList();
        T GetById(string id);
        void Create(T item);
        void Update(T item);
        void Delete(string id);
        void Save(T item);
    }
}
