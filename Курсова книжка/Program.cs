using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Курсова_книжка
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().Split(": ")[1].Trim();
            string[] subjects = Console.ReadLine().Split("; ");

            Student student = new Student(name);

            foreach (string subject in subjects)
            {
                string[] tokens = subject.Split(", ");
                int semester = int.Parse(tokens[0]);
                string discipline = tokens[1];
                int numberOfLectures = int.Parse(tokens[2]);
                int numberOfExercises = int.Parse(tokens[3]);
                string teacher = tokens[4];
                double grade = double.Parse(tokens[5]);

                Discipline disc = new Discipline(discipline, numberOfLectures, numberOfExercises, teacher, grade);

                if (student.Semesters.Any(x => x.SemesterNumber == semester))
                {
                    student.Semesters.Find(x => x.SemesterNumber == semester).AddDiscipline(disc);
                }
                else
                {
                    student.Semesters.Add(new Semester(semester, new List<Discipline>() { disc }));
                }
            }

                Console.WriteLine("Студент: {0}", student.studentsName);
                Console.WriteLine("Общо изучавани дисциплини: {0}", student.CalculatorAverage("disciplines"));
                Console.WriteLine("Среден успех по семестри и общ хорариум:");
                int counter = 1;
                foreach (Semester sem in student.Semesters)
                {
                    Console.WriteLine("{0}. Семестър {1}, {2}: {3:0.00}", counter++, sem.SemesterNumber,
                        sem.CalculateAverage("lectures") + sem.CalculateAverage("exercises"), sem.CalculateAverage("grade"));
                }
                Console.WriteLine("Общ среден успех: {0:0.00}", student.CalculatorAverage("grade"));
           
        }
    }
}
