using System.Collections.Generic;
using University.entity;
using University.repository;

namespace University.service
{
    internal class GroupService : AbstractService<Group>, IGroupService
    {
        private readonly IGroupRepository _groupRepository;

        public GroupService(IGroupRepository groupRepository) : base(groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public List<Student> FindStudent(string firstName, string secondName)
        {
            return _groupRepository.FindStudent(firstName, secondName);
        }
    }
}