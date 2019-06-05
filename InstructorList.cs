using System;
using System.Collections.Generic;

namespace NSS
{
    class InstructorList
    {
        private List<Instructor> _instructors = new List<Instructor>();

        public Instructor createInstructor(string FirstName, string LastName)
        {
            Instructor Instructor = new Instructor(_instructors, FirstName, LastName) { };
            _instructors.Add(Instructor);

            return Instructor;
        }

        public List<Instructor> getAll(){
            return _instructors;
        }

    }

}