using System;
using System.Collections.Generic;

namespace NSS
{
    class Exercise
    {
        public Exercise( List<Exercise> List, string Name, string Language) {
            _id = List.Count + 1;
            _name = Name;
            _language = Language;
            _studentId = 0;
        }

        public Exercise(int Id, string Name, string Language, int StudentId){
            _id = Id;
            _name = Name;
            _language = Language;
            _studentId = StudentId;
        }


        private int _id;
        private string _name;
        private string _language;
        private int _studentId;

        public int Id(){
            return _id;
        }

        public string Name(){
            return _name;
        }

        public string Language(){
            return _language;
        }
    }
}