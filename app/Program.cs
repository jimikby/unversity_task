using System;
using System.Collections.Generic;
using System.Diagnostics;
using University.entity;
using University.repository;
using University.service;
using University.util;

namespace University.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentService(new StudentRepository(new BinaryDataHepler<List<Student>>("student.bin", true)));
            var groupService = new GroupService(new GroupRepository(new JsonDataHepler<List<Group>>("group.json", true)));
            var facultyService = new FacultyService(new FacultyRepository(new JsonDataHepler<List<Faculty>>("faculty.json", true)));

            studentService.Create(new Student("Dzmitry", "Talkachou", 55001));
            studentService.Create(new Student("Akesei", "Petrenko", 55002));
            studentService.Create(new Student("Nikolai", "Zaharchenko", 55003));
            studentService.Create(new Student("Valenina", "Stepanenko", 55004));
            studentService.Create(new Student("Olga", "Reut", 55005));
            studentService.Create(new Student("Svetlana", "Kalinkina", 55006));
            studentService.Create(new Student("Svetlana", "Alekseeva", 55007));
            studentService.Update(new Student("Svetlana", "Malinkina", 55006),6);
            var students = studentService.SortBySecondName();
            var count = studentService.CountStudentsByFirstName("Svetlana");
            Debug.WriteLine(count);
            var names = studentService.GetAllNames();
            foreach (var n in names)
            {
                Debug.WriteLine(n);
            }
            groupService.Create(new Group(55, students));
            var studentsByNameFromGroup = groupService.FindStudent("Svetlana", "Malinkina");
            foreach (var s in studentsByNameFromGroup)
            {
                Debug.WriteLine(s.FirstName + " " + s.SecondName + " id:" + s.Uid);
            }

            facultyService.Create(new Faculty("FKSIS", groupService.Read()));
            var studentsByNameFromFaculty = facultyService.FindStudent("Svetlana", "Malinkina");
            foreach (var s in studentsByNameFromFaculty)
            {
                Debug.WriteLine(s.FirstName + " " + s.SecondName + " id:" + s.Uid);
            }
        }
    }
}
