using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
