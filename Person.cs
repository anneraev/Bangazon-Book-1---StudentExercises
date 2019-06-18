using System;
using System.Collections.Generic;

namespace NSS {
    class Person {
        public Person(string FirstName, string LastName){
            _id = Guid.NewGuid();
            _firstName = FirstName;
            _lastName = LastName;
        }
        private Guid _id;
        private string _firstName;
        private string _lastName;
        public string SlackHandle {get; set;}
        private string _cohort;

        public void setCohort(string Cohort){
            _cohort = Cohort;
        }

        public string Cohort(){
            return _cohort;
        }

        public Guid Id(){
            return _id;
        }

        public string FirstName(){
            return _firstName;
        }

        public string LastName(){
            return _lastName;
        }

        public string Name(){
            return $"{_firstName} {_lastName}";
        }
    }
}