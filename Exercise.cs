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
        }

        private int _id;
        private string _name;
        private string _language;
    }
}