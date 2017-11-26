using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.repository;
using University.util;

namespace University.service
{
    internal abstract class AbstractService<T> : IService<T> where T : IEntity
    {
        protected IRepository<T> Repository { get; }

        protected AbstractService(IRepository<T> repository)
        {
            Repository = repository;
        }

        public void Create(T t)
        {
            Repository.Create(t);
        }

        public List<T> Read()
        {
            return Repository.Read();
        }

        public void Update(T t, int id)
        {
            Repository.Update(t,id);
        }

        public bool Delete(int id)
        {
            return Repository.Delete(id);
        }
    }
}
