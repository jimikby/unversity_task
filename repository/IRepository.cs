using System.Collections.Generic;

namespace University.repository
{
    internal interface IRepository<T>
    {
        void Create(T t);
        List<T> Read();
        void Update(T t, int id);
        bool Delete(int id);
    }
}
