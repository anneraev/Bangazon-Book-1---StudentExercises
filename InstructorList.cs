using System;
using System.Collections.Generic;

namespace NSS
{
    class InstructorList
    {
        private List<Instructor> _instructors = new List<Instructor>();

        public void createInstructor(string FirstName, string LastName)
        {
            Instructor Instructor = new Instructor(_instructors, FirstName, LastName) { };
            _instructors.Add(Instructor);
        }

    }

}