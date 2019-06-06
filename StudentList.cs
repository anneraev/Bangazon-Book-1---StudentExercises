using System;
using System.Collections.Generic;

namespace NSS
{
    class StudentList
    {
        private List<Student> _students = new List<Student>();

        public Student createStudent(string FirstName, string LastName)
        {
            Student Student = new Student(_students, FirstName, LastName) { };
            _students.Add(Student);
            return Student;
        }

        public List<Student> getAll()
        {
            return _students;
        }

    }
}