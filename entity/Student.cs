using System;

namespace University.entity
{
    [Serializable]
    internal class Student : IEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int UniqueNumber { get; set; }

        public int Uid { get; set; }

        public Student(string firstName, string secondName, int uniqueNumber)
        {
            FirstName = firstName;
            SecondName = secondName;
            UniqueNumber = uniqueNumber;
        }

        public Student()
        {
        }
    }
}
