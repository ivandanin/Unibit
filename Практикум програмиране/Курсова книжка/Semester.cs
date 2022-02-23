using System.Collections.Generic;
using System.Linq;

namespace Курсова_книжка
{
        class Semester : IHasAverage
    {
        public List<Discipline> Disciplines { get; private set; }
        public int SemesterNumber { get; internal set; }
        public Semester(int semester)
        {
            this.SemesterNumber = semester;
            this.Disciplines = new List<Discipline>();
        }

        public Semester(int semester, List<Discipline> disc)
        {
            this.SemesterNumber = semester;
            this.Disciplines = disc;
        }
        
        public void AddDiscipline(Discipline disc)
        {
            this.Disciplines.Add(disc);
        }
        public double CalculateAverage(string type)
        {
            switch (type)
            {
                case "grade":
                    return this.Disciplines.Sum(x => x.Grade) / this.Disciplines.Count;
                case "lectures":
                    return this.Disciplines.Sum(x => x.Lectures);
                case "exercises":
                    return this.Disciplines.Sum(x => x.Exericses);
                default:
                    return 0d;
            }
        }
    }
}