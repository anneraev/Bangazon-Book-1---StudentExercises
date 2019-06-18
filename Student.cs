using System;
using System.Collections.Generic;

namespace NSS {
    class Student : Person {
        public Student (string FirstName, string LastName) : base(FirstName, LastName){

        }

        private List<Exercise> _exerciseList = new List<Exercise>();

        public void Assign(Exercise Exercise){
            _exerciseList.Add(Exercise);
        }

        public List<Exercise> ExerciseList() {
            return _exerciseList;
        }

        public string printInfo(){
            string wholeString = $"Name: {this.Name()}";
            wholeString += Environment.NewLine;
            wholeString += $"Cohort: {this.Cohort()}";
            wholeString += Environment.NewLine;
            wholeString += $"Assigned Exercies: ";
            foreach (Exercise Exercise in _exerciseList)
            {
                wholeString += $"{Exercise.printInfo()}";
                wholeString += Environment.NewLine;
            }
            wholeString += $"Slack: {SlackHandle}";
            wholeString += Environment.NewLine;
            return wholeString;
        }
    }
}