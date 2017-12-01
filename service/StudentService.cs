using System.Collections.Generic;
using University.entity;
using University.repository;

namespace University.service
{
    internal class StudentService : AbstractService<Student> , IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository) : base(studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> SortBySecondName()
        {
            return _studentRepository.SortBySecondName();
        }

        public int CountStudentsByFirstName(string name)
        {
            return _studentRepository.CountStudentsByFirstName(name);
        }

        public List<string> GetAllNames()
        {
            return _studentRepository.GetAllNames();
        }
    }
}
