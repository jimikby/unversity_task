using System.Collections.Generic;
using University.entity;
using Group = University.entity.Group;

namespace University.service
{
    internal interface IGroupService : IService<Group>
    {
        List<Student> FindStudent(string firstName, string secondName);
    }
}
