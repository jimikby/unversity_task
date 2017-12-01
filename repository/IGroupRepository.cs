using System.Collections.Generic;
using University.entity;
using Group = University.entity.Group;

namespace University.repository
{
    internal interface IGroupRepository : IRepository<Group>
    {
        List<Student> FindStudent(string firstName, string secondName);
    }
}
