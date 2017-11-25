using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.entity;
using University.repository;

namespace University.service
{
    internal class FacultyService : AbstractService<Faculty>
    {
        public FacultyService(FacultyRepository facultyRepository) : base(facultyRepository)
        {
        }
    }
}
