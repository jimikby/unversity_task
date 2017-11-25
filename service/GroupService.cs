using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.repository;

namespace University.service
{
    internal class GroupService : AbstractService<Group>
    {
        public GroupService(GroupRepository facultyRepository) : base(facultyRepository)
        {
        }
    }
}
