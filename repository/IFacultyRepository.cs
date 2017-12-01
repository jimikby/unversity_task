using System.Collections.Generic;
using University.entity;

namespace University.repository
{
    internal interface IFacultyRepository : IRepository<Faculty>
    {
        List<Student> FindStudent(string firstName, string secondName);
    }
}
