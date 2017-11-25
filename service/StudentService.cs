using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.repository;

namespace University.service
{
    internal class StudentService : AbstractService<Student>
    {
        public StudentService(StudentRepository studentRepository) : base(studentRepository)
        {
        }

        public List<Student> SortBySecondName()
        {
            return ((StudentRepository) Repository).SortBySecondName();
        }

        public int CountStudentsByFirstName(string name)
        {
            return ((StudentRepository)Repository).CountStudentsByFirstName(name);
        }

        public List<string> GetAllNames()
        {
            return ((StudentRepository)Repository).GetAllNames();
        }
    }
}
