using System;
using System.Collections.Generic;
namespace NSS {
    class Instructor : Person {
        public Instructor (string FirstName, string LastName) : base(FirstName, LastName){}

        private string _specialty;

        public void setSpecialty(string Specialty){
            _specialty = Specialty;
        }

        public void AssignExercise(Student Student, Exercise Exercise) {
            Exercise ExerciseCopy = new Exercise(Exercise.Id(), Exercise.Name(), Exercise.Language(), Student.Id());
            Student.Assign(ExerciseCopy);
        }

        public string printInfo(){
            string wholeString = $"Name: {this.Name()}";
            wholeString += Environment.NewLine;
            wholeString += $"Cohort: {this.Cohort()}";
            wholeString += Environment.NewLine;
            wholeString += $"Specialty: {_specialty}";
            wholeString += Environment.NewLine;
            wholeString += $"Slack: {SlackHandle}";
            wholeString += Environment.NewLine;
            return wholeString;
        }

    }
}