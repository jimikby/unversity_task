using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.util;

namespace University.repository
{
    internal class StudentRepository : AbstractRepository<Student>
    {
        public StudentRepository(IDataSerivce<List<Student>> dataSerivce) : base(dataSerivce)
        {
        }

        public List<Student> SortBySecondName()
        {
            return DataSerivce.Read().OrderBy(student => student.SecondName).ToList();
        }

        public int CountStudentsByFirstName(string name)
        {
            return DataSerivce.Read().Count(student => student.FirstName.Contains(name));
        }

        public List<string> GetAllNames()
        {
            return (from student in DataSerivce.Read() select student.FirstName + " " + student.SecondName).ToList();
        }
    }
}
