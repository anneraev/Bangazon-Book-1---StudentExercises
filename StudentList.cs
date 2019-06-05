using System;
using System.Collections.Generic;

namespace NSS
{
    class StudentList
    {
        private List<Student> _students;

        public void createStudent(string FirstName, string LastName)
        {
            Student Student = new Student(_students, FirstName, LastName) { };
            _students.Add(Student);
        }

    }
}