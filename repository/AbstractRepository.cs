using System.Collections.Generic;
using System.Linq;
using University.entity;
using University.util;

namespace University.repository
{
    internal abstract class AbstractRepository<T> : IRepository<T> where T : IEntity  
    {

        protected IDataHelper<List<T>> DataHelper { get; }

        protected AbstractRepository(IDataHelper<List<T>> dataHepler)
        {
            DataHelper = dataHepler;
        }

        public void Create(T t)
        {
            var ts = DataHelper.Read() ?? new List<T>();
            var id = 0;
            if (ts.Count != 0)
            {
                id = ts.Max(t1 => t1.Uid);
            }
            t.Uid = ++id;
            ts.Add(t);
            DataHelper.Write(ts);
        }

        public List<T> Read()
        {
            return DataHelper.Read();
        }

        public void Update(T t, int id)
        {
            t.Uid = id;
            var ts = DataHelper.Read();
            var index = ts.FindIndex(t1 => t1.Uid == id);
            ts[index] = t;
            DataHelper.Write(ts);
        }

        public bool Delete(int id)
        {
            var ts = DataHelper.Read();
            if (ts.Count == 0) return false;
            var t = ts.FirstOrDefault(t1 => t1.Uid == id);
            ts.Remove(t);
            DataHelper.Write(ts);
            return true;
        }


    }
}
