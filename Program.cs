using System;
using System.Collections.Generic;
using NSS;
using System.Linq;

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
            Instructor1.SlackHandle = "@jisie";
            Instructor2.SlackHandle = "@andy";
            Instructor3.SlackHandle = "@kristin";
            Instructor4.SlackHandle = "@leah";
            foreach (Instructor Instructor in InstructorList.getAll())
            {
                Cohort31.Assign(Instructor);
            }

            StudentList StudentList = new StudentList();

            Student Student1 = StudentList.createStudent("Anne", "Vick");
            Student Student2 = StudentList.createStudent("Jameka", "Echols");
            Student Student3 = StudentList.createStudent("Chris", "Morgan");
            Student Student4 = StudentList.createStudent("Meag", "Mueller");
            Student1.SlackHandle = "@anne";
            Student2.SlackHandle = "@jameka";
            Student3.SlackHandle = "@chris";
            Student4.SlackHandle = "@meag";
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

            foreach (Cohort Cohort in CohortList.AllCohorts())
            {
                Console.WriteLine(Cohort.printInfo());
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("PART 2");
            Console.WriteLine("--------------------------");

            Cohort30.Assign(StudentList.createStudent("Larry", "Larryson"));
            Cohort30.Assign(StudentList.createStudent("Kristen", "Kristinson"));
            Cohort30.Assign(StudentList.createStudent("Loshanna", "Loshannason"));
            Cohort30.Assign(StudentList.createStudent("Tre", "Treson"));
            Cohort30.Assign(StudentList.createStudent("Overachieving", "Asshat"));

            ExerciseList.createExercise("OverlyExcited", "Javascript");
            ExerciseList.createExercise("SolarSystem", "Javascript");
            ExerciseList.createExercise("CarLot", "Javascript");
            ExerciseList.createExercise("DynamicCards", "Javascript");

            Cohort30.Assign(InstructorList.createInstructor("Idont", "Remember"));
            Cohort30.Assign(InstructorList.createInstructor("Who", "Taught"));
            Cohort30.Assign(InstructorList.createInstructor("Cohort", "Thirty"));

            //note to self: never do it like this again. Just wanted to see if I could keep it all straight in my head long enough to type out working code.
            //for each student wher student cohort is cohort 30, iterate through a list of exercies that are of the javascript langauge and assign those to the student.
            StudentList.getAll().Where(student => student.Cohort() == Cohort30.Name()).ToList().ForEach(student => ExerciseList.getAll().Where(exercise => exercise.Language() == "Javascript").ToList().ForEach(exercise => student.Assign(exercise)));

            Student Overachiever = StudentList.getAll().First(Student=> Student.Name() == "Overachieving Asshat");

            ExerciseList.getAll().Where(exercise => exercise.Language() == "C#").ToList().ForEach(exercise => Overachiever.Assign(exercise));

            Cohort30.Assign(StudentList.createStudent("Lazy", "Asshole"));

            Console.WriteLine("All javascript exercises");
            //For all exercises where javascript is the language, write out the name of the exercise and its langauge.
            ExerciseList.getAll().Where(exercise => exercise.Language() == "Javascript").ToList().ForEach(exercise => Console.WriteLine($"{exercise.Name()} is in {exercise.Language()}"));
            Console.WriteLine("----------------------");

            Console.WriteLine("All students in Cohort 30");
            StudentList.getAll().Where(student => student.Cohort() == Cohort30.Name()).ToList().ForEach(student => Console.WriteLine($"{student.Name()} is in {student.Cohort()}"));
            Console.WriteLine("----------------------");

            Console.WriteLine("All Instructors in Cohort 30");
            InstructorList.getAll().Where(instructor => instructor.Cohort() == Cohort30.Name()).ToList().ForEach(instructor => Console.WriteLine($"{instructor.Name()} is in {instructor.Cohort()}"));
            Console.WriteLine("----------------------");
            Console.WriteLine("All students sorted by LastName");
            StudentList.getAll().OrderBy(student => student.LastName()).ToList().ForEach(student => Console.WriteLine($"{student.LastName()}, {student.FirstName()}"));

            Console.WriteLine("----------------------");
            Console.WriteLine("All students working on 0 exercises:");
            StudentList.getAll().Where(student => student.ExerciseList().Count == 0).ToList().ForEach(student => Console.WriteLine(student.Name()));

            Console.WriteLine("----------------------");
            Console.WriteLine("The student working on the most exercises:");
            int MaxExercises = StudentList.getAll().Select(student => student.ExerciseList().Count).Max();

            Console.WriteLine(StudentList.getAll().First(student => student.ExerciseList().Count == MaxExercises).Name());

            Console.WriteLine("----------------------");
            Console.WriteLine("The number of students in each cohort:");
            IEnumerable<EnrollmentReport> enrollmentReports = CohortList.AllCohorts().Select(cohort => new EnrollmentReport {
                CohortName = cohort.Name(),
                StudentCount = StudentList.getAll().Where(student => student.Cohort() == cohort.Name()).ToList().Count
            });

            foreach(EnrollmentReport report in enrollmentReports){
                Console.WriteLine($"{report.CohortName} has {report.StudentCount} students.");
            }
        }
    }
}
