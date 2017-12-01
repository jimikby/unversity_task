using System;
using System.Collections.Generic;

namespace University.entity
{
    [Serializable]
    internal class Group : IEntity
    {
        public int GroupNumber { get; set; }
        public List<Student> Students { get; set; }
        public int Uid { get; set; }

        public Group(int groupNumber, List<Student> students)
        {
            GroupNumber = groupNumber;
            Students = students;
        }

        public Group()
        {
        }
    }
}
