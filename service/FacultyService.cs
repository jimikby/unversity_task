using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.repository;

namespace University.service
{
    internal class FacultyService : AbstractService<Faculty> , IFacultyService
    {
        private readonly IFacultyRepository _facultyRepository;

        public FacultyService(IFacultyRepository faculityReository) : base(faculityReository)
        {
            _facultyRepository = faculityReository;
        }

        public List<Student> FindStudent(string firstName, string secondName)
        {
            return _facultyRepository.FindStudent(firstName, secondName);
        }
    }
}
