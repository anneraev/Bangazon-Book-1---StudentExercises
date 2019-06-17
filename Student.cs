using System;
using System.Collections.Generic;

namespace NSS {
    class Student {

        public Student(List<Student> List, string FirstName, string LastName){
            _id = List.Count + 1;
            _firstName = FirstName;
            _lastName = LastName;
        }

        private int _id;
        private string _firstName;
        private string _lastName;
        public string SlackHandle {get; set;}
        private string _cohort;

        private List<Exercise> _exerciseList = new List<Exercise>();

        public void setCohort(Cohort Cohort){
            _cohort = Cohort.Name();
        }

        public string Cohort(){
            return _cohort;
        }

        public int Id(){
            return _id;
        }

        public void Assign(Exercise Exercise){
            _exerciseList.Add(Exercise);
        }

        public string Name(){
            return $"{_firstName} {_lastName}";
        }

        public string printInfo(){
            string wholeString = $"Name: {this.Name()}";
            wholeString += Environment.NewLine;
            wholeString += $"Cohort: {_cohort}";
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