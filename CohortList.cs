using System;
using System.Collections.Generic;

namespace NSS {
    class CohortsList {
        private List<Cohort> _cohorts = new List<Cohort>();

        public List<Cohort> AllCohorts(){
            return _cohorts;
        }

        public Cohort createCohort(string Name, string CohortNum){
            Cohort Cohort = new Cohort(Name, CohortNum){};
            _cohorts.Add(Cohort);
            return Cohort;
        }
    }
}