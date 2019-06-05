using System;
using System.Collections.Generic;

namespace NSS {
        class ExerciseList {
        private List<Exercise> _exercises = new List<Exercise>{};

        public List<Exercise> Exercises(){
            return _exercises;
        }

        public Exercise createExercise(string Name, string Language){
            Exercise Exercise = new Exercise(_exercises, Name, Language){};
            _exercises.Add(Exercise);
            return Exercise;
        }


    }

}