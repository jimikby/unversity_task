using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.repository;
using University.service;

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
