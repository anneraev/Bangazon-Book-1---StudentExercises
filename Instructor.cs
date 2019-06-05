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
        private Cohort _cohort;
        private string _specialty;

        public string Specialty {get {
            return _specialty;
        }}

        public void setSpecialty(string Specialty){
            _specialty = Specialty;
        }

        public void AssignExercise(Student Student, Exercise Exercise) {
            Exercise ExerciseCopy = new Exercise(Exercise.Id(), Exercise.Name(), Exercise.Language(), Student.Id());
            Student.Assign(ExerciseCopy);
        }
        public void setCohort(Cohort Cohort){
            _cohort = Cohort;
        }
    }
}