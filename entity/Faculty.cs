using System;
using System.Collections.Generic;

namespace University.entity
{
    [Serializable]
    internal class Faculty : IEntity
    {
        public int Uid { get; set; }
        public string FacultyName { get; set; }

        public List<Group> Groups { get; set; }

        public Faculty(string facultyName, List<Group> groups)
        {
            FacultyName = facultyName;
            Groups = groups;
        }

        public Faculty()
        {  
        }
    }
}
