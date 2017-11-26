using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.util;

namespace University.repository
{
    internal class StudentRepository : AbstractRepository<Student> , IStudentRepository
    {
        public StudentRepository(IDataHelper<List<Student>> dataHepler) : base(dataHepler)
        {
        }

        public List<Student> SortBySecondName()
        {
            return DataHelper.Read().OrderBy(student => student.SecondName).ToList();
        }

        public int CountStudentsByFirstName(string name)
        {
            return DataHelper.Read().Count(student => student.FirstName.Contains(name));
        }

        public List<string> GetAllNames()
        {
            return (from student in DataHelper.Read() select student.FirstName + " " + student.SecondName).ToList();
        }
    }
}
