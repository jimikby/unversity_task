using System.Collections.Generic;
using University.entity;

namespace University.service
{
    internal interface IStudentService : IService<Student>
    {
        List<Student> SortBySecondName();
        int CountStudentsByFirstName(string name);
        List<string> GetAllNames();
    }
}
