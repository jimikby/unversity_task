using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;

namespace University.repository
{
    internal interface IFacultyRepository : IRepository<Faculty>
    {
        List<Student> FindStudent(string firstName, string secondName);
    }
}
