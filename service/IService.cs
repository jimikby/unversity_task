using System.Collections.Generic;

namespace University.service
{
    internal interface IService<T>
    {
        void Create(T t);
        List<T> Read();
        void Update(T t, int id);
        bool Delete(int id);
    }
}
