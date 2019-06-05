using System;
using System.Collections.Generic;

namespace NSS {
    class CohortsList {
        private List<Cohort> _cohorts = new List<Cohort>();

        public void createCohort(string Name){
            Cohort Cohort = new Cohort(_cohorts, Name){};
            _cohorts.Add(Cohort);
        }
    }
}