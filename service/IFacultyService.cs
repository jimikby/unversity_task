using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;

namespace University.service
{
    internal interface IFacultyService : IService<Faculty>
    {
        List<Student> FindStudent(string firstName, string secondName);
    }
}
