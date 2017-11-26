using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
