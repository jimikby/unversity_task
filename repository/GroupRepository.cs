using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
         var selectedStudent = from groups in DataHelper.Read()
                               from student in groups.Students
                               where student.FirstName == firstName
                               where student.SecondName == secondName
                               select student;
            return new List<Student>(selectedStudent);
        }
    }
}
