using System.Collections.Generic;
using System.Linq;

namespace Курсова_книжка
{
    class Student : IHasAverage
    {
        public string studentsName { get; set; }

        public List<Semester> Semesters { get; private set; }

        public Student(string student)
        {
            this.studentsName = student;
            this.Semesters = new List<Semester>();
        }
        public double CalculatorAverage(string type)
        {
            switch (type)
            {
                case "grade":
                    return this.Semesters.Sum(x => x.CalculateAverage("grade")) / this.Semesters.Count;
                case "disciplines":
                    return this.Semesters.Sum(x => x.Disciplines.Count);
                default:
                    int horarium = (int)(this.Semesters.Sum(x => x.CalculateAverage("lectures") + this.Semesters.Sum(x => x.CalculateAverage("exercises"))));
                    return horarium;
            }
        }
    }
    }
