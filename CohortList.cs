using System;
using System.Collections.Generic;

namespace NSS {
    class CohortsList {
        private List<Cohort> _cohorts = new List<Cohort>();

        public Cohort createCohort(string Name, string CohortNum){
            Cohort Cohort = new Cohort(_cohorts, Name, CohortNum){};
            _cohorts.Add(Cohort);
            return Cohort;
        }
    }
}