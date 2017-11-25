using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
