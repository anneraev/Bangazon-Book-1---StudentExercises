using System;
using System.Collections.Generic;

namespace NSS {
    class Student {

        public Student(List<Student> Students, string FirstName, string LastName){
            _id = Students.Count + 1;
            _firstName = FirstName;
            _lastName = LastName;
        }
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _slackhandle;
        private int _cohortId;
    }
}