using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.util;

namespace University.repository
{
    internal class AbstractRepository<T> : IRepository<T> where T : IEntity  
    {

        protected IDataSerivce<List<T>> DataSerivce { get; }
        public AbstractRepository(IDataSerivce<List<T>> dataSerivce)
        {
            DataSerivce = dataSerivce;
        }

        public void Create(T t)
        {
            var ts = DataSerivce.Read() ?? new List<T>();
            var id = 0;
            if (ts.Count != 0)
            {
                id = ts.Max(t1 => t1.Uid);
            }
            t.Uid = ++id;
            ts.Add(t);
            DataSerivce.Write(ts);
        }

        public List<T> Read()
        {
            return DataSerivce.Read();
        }

        public void Update(T t, int id)
        {
            t.Uid = id;
            var ts = DataSerivce.Read();
            var index = ts.FindIndex(t1 => t1.Uid == id);
            ts[index] = t;
            DataSerivce.Write(ts);
        }

        public bool Delete(int id)
        {
            var ts = DataSerivce.Read();
            if (ts.Count == 0) return false;
            var t = ts.FirstOrDefault(t1 => t1.Uid == id);
            ts.Remove(t);
            DataSerivce.Write(ts);
            return true;
        }


    }
}
