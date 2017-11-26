using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
