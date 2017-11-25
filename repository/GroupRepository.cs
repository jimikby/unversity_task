using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.util;

namespace University.repository
{
    internal class GroupRepository : AbstractRepository<Group>
    {
        public GroupRepository(IDataSerivce<List<Group>> dataSerivce) : base(dataSerivce)
        {
        }

        public static List<Student> Sort()
        {
            throw new NotImplementedException();
        }

        public static List<Student> CountByFirstName()
        {
            throw new NotImplementedException();
        }

        public static List<string> GetAllNames()
        {
            throw new NotImplementedException();
        }
    }
}
