using System;
using System.Collections.Generic;
namespace NSS {
    class Instructor {
        public Instructor(List<Instructor> List, string FirstName, string LastName){
            _id = List.Count + 1;
            _firstName = FirstName;
            _lastName = LastName;
        }
        private int _id;

        private string _firstName;
        private string _lastName;
        private string _slackHandle;
        private int _cohortId;
        private int specialty;
        public void AssignExercise(Student Student, Exercise Exercise) {
        }
    }
}