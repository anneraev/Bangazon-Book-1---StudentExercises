using System;
using System.Collections.Generic;
using NSS;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseList ExerciseList = new ExerciseList();

            Exercise Exercise1 = ExerciseList.createExercise("Dictionaries", "C#");
            Exercise Exercise2 = ExerciseList.createExercise("Lists", "C#");
            Exercise Exercise3 = ExerciseList.createExercise("Classes", "C#");
            Exercise Exercise4 = ExerciseList.createExercise("Student Exercises", "C#");

            CohortsList CohortList = new CohortsList();

            Cohort Cohort28 = CohortList.createCohort("Full Stack", "C28");
            Cohort Cohort29 = CohortList.createCohort("Full Stack", "C29");
            Cohort Cohort30 = CohortList.createCohort("Full Stack", "C30");
            Cohort Cohort31 = CohortList.createCohort("Full Stack", "C31");

            InstructorList InstructorList = new InstructorList();

            Instructor Instructor1 = InstructorList.createInstructor("Jisie", "David");
            Instructor Instructor2 = InstructorList.createInstructor("Andy", "Collins");
            Instructor Instructor3 = InstructorList.createInstructor("Kristin", "Norris");
            Instructor Instructor4 = InstructorList.createInstructor("Leah", "Hoefling");
            Instructor1.setSpecialty("Being blunt.");
            Instructor2.setSpecialty("Unknown.");
            Instructor3.setSpecialty("Snacks.");
            Instructor4.setSpecialty("Illustration.");
            foreach (Instructor Instructor in InstructorList.getAll())
            {
                Cohort31.Assign(Instructor);
            }

            StudentList StudentList = new StudentList();

            Student Student1 = StudentList.createStudent("Anne", "Vick");
            Student Student2 = StudentList.createStudent("Jameka", "Echols");
            Student Student3 = StudentList.createStudent("Chris", "Morgan");
            Student Student4 = StudentList.createStudent("Meag", "Mueller");
            foreach (Student Student in StudentList.getAll())
            {
                Cohort31.Assign(Student);
            }

            foreach (Student Student in StudentList.getAll())
            {
                Instructor1.AssignExercise(Student, Exercise1);
                Instructor2.AssignExercise(Student, Exercise2);
                Instructor3.AssignExercise(Student, Exercise3);
                Instructor4.AssignExercise(Student, Exercise4);
            }

        }
    }
}
