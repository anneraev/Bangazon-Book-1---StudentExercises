using System;
using System.Collections.Generic;

namespace NSS {
        class ExerciseList {
        private List<Exercise> _exercises = new List<Exercise>{};

        public Exercise createExercise(string Name, string Language){
            Exercise Exercise = new Exercise(_exercises, Name, Language){};
            _exercises.Add(Exercise);
            return Exercise;
        }

        public List<Exercise> getAll() {
            return _exercises;
        }


    }

}