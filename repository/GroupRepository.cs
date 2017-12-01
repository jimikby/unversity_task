using System.Collections.Generic;
using System.Linq;
using University.entity;
using University.util;

namespace University.repository
{
    internal class GroupRepository : AbstractRepository<Group> , IGroupRepository
    {
        public GroupRepository(IDataHelper<List<Group>> dataHepler) : base(dataHepler)
        {
        }

        public List<Student> FindStudent(string firstName, string secondName)
        { 
         var selectedStudent = DataHelper.Read()
             .SelectMany(groups => groups.Students, (groups, student) => new {groups, student})
             .Where(@t => @t.student.FirstName == firstName)
             .Where(@t => @t.student.SecondName == secondName)
             .Select(@t => @t.student);
            return new List<Student>(selectedStudent);
        }
    }
}
