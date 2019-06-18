using System;
using System.Collections.Generic;

namespace NSS
{
    class Exercise
    {
        public Exercise(string Name, string Language) {
            _id = Guid.NewGuid();
            _name = Name;
            _language = Language;
        }

        public Exercise(Guid Id, string Name, string Language, Guid StudentId){
            _id = Id;
            _name = Name;
            _language = Language;
            _studentId = StudentId;
        }


        private Guid _id;
        private string _name;
        private string _language;
        private Guid _studentId;

        public Guid Id(){
            return _id;
        }

        public string Name(){
            return _name;
        }

        public string Language(){
            return _language;
        }

        public string printInfo(){
            string wholeString = $"Title: {_name}";
            wholeString += Environment.NewLine;
            wholeString += $"Langauge:{_language}";
            wholeString += Environment.NewLine;
            return wholeString;
        }
    }
}