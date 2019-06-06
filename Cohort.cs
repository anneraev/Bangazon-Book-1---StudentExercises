using System;
using System.Collections.Generic;

namespace NSS {
    class Cohort {
        public Cohort(List<Cohort> Cohorts, string Name, string CohortNum){
            _id = Cohorts.Count + 1;
            _name = Name;
            _cohortNum = CohortNum;
        }
        private int _id;
        private string _name;
        private string _cohortNum;
        private List<Student> _students = new List<Student>();
        private List<Instructor> _instructors = new List<Instructor>();
        public void Assign(Instructor Instructor){
            _instructors.Add(Instructor);
            Instructor.setCohort(this);
        }

        public void Assign(Student Student){
            _students.Add(Student);
            Student.setCohort(this);
        }

        public string Name(){
            return $"{_name} {_cohortNum}";
        }

        public string printInfo(){
            string wholeString = $"Name: {this.Name()}";
            wholeString += Environment.NewLine;
            wholeString += "Instructors: ";
            foreach (Instructor Instructor in _instructors)
            {
                wholeString += Instructor.printInfo();
                wholeString += Environment.NewLine;
            }
            wholeString += Environment.NewLine;
            wholeString += "Students: ";
            foreach (Student Student in _students)
            {
                wholeString += Student.printInfo();
                wholeString += Environment.NewLine;
            }
            wholeString += Environment.NewLine;
            return wholeString;
        }

    }
}