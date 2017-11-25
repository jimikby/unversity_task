using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.service
{
    internal class UniversitySerivce
    {
        private readonly FacultyService _facultyService;
        private readonly GroupService _groupService;
        private readonly StudentService _studentService;

        public UniversitySerivce(FacultyService facultyService, GroupService groupService, StudentService studentService)
        { 
            _facultyService = facultyService;
            _groupService = groupService;
            _studentService = studentService;
        }
    }
}
