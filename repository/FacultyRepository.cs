using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.util;

namespace University.repository
{
    internal class FacultyRepository : AbstractRepository<Faculty> , IFacultyRepository
    {
        public FacultyRepository(IDataHelper<List<Faculty>> dataHepler) : base(dataHepler)
        {
        }
        public List<Student> FindStudent(string firstName, string secondName)
        {
            var selectedStudent = from faculties in DataHelper.Read()
                                  from groups in faculties.Groups
                                  from student in groups.Students
                                  where student.FirstName == firstName
                                  where student.SecondName == secondName
                                  select student;
            return new List<Student>(selectedStudent);
        }
    }
}
