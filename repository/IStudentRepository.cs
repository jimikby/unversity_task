using System.Collections.Generic;
using University.entity;

namespace University.repository
{
    internal interface IStudentRepository : IRepository<Student>
    {
        List<Student> SortBySecondName();
        int CountStudentsByFirstName(string name);
        List<string> GetAllNames();
    }
}
