using System.Collections.Generic;

namespace ModelBinding.Models.repositories
{
    public interface IRepositories<T> where T :class 
    {
        T this [int id] { set; get; }

        IEnumerable<T> Objects { get; }
        
        void Delete(int id);

        bool Contains(int id);

        void Update(T element);
    }
}