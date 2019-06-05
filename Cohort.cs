using System;
using System.Collections.Generic;
namespace NSS {
    class Cohort {
        public Cohort(List<Cohort> Cohorts, string Name){
            _id = Cohorts.Count + 1;
            _name = Name;
        }
        private int _id;
        private string _name;
        private List<Student> _students = new List<Student>();
        private List<Instructor> _instructors = new List<Instructor>();

    }
}