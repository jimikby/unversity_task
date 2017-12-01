using System.Collections.Generic;
using System.Linq;
using University.entity;
using University.util;

namespace University.repository
{
    internal class FacultyRepository : AbstractRepository<Faculty> , IFacultyRepository
    {
        public FacultyRepository(IDataHelper<List<Faculty>> dataHepler) : base(dataHepler)
        {
        }
        public List<Student> FindStudent(string firstName, string secondName)
        {
            var selectedStudent = DataHelper.Read()
                .SelectMany(faculties => faculties.Groups, (faculties, groups) => new {faculties, groups})
                .SelectMany(@t => @t.groups.Students, (@t, student) => new {@t, student})
                .Where(@t => @t.student.FirstName == firstName)
                .Where(@t => @t.student.SecondName == secondName)
                .Select(@t => @t.student);
            return new List<Student>(selectedStudent);
        }
    }
}
