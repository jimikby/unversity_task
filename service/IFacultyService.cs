using System.Collections.Generic;
using University.entity;

namespace University.service
{
    internal interface IFacultyService : IService<Faculty>
    {
        List<Student> FindStudent(string firstName, string secondName);
    }
}
