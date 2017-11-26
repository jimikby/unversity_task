using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using University.entity;
using Group = University.entity.Group;

namespace University.repository
{
    internal interface IGroupRepository : IRepository<Group>
    {
        List<Student> FindStudent(string firstName, string secondName);
    }
}
