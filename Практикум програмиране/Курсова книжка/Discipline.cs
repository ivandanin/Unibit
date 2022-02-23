namespace Курсова_книжка
{
    internal class Discipline
    {
        private string discipline;
        private int numberOfLectures;
        private int numberOfExercises;
        private string teacher;
        private double grade;

        public Discipline(string discipline, int numberOfLectures, int numberOfExercises, string teacher, double grade)
        {
            this.discipline = discipline;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
            this.teacher = teacher;
            this.grade = grade;
        }

        public string Dizcipline
        {
            get
            {
                return discipline;
            }
            set
            {
                this.discipline = value;
            }
        }
        public int Lectures
        {
            get
            {
                return numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }
        public int Exericses
        {
            get
            {
                return numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }
        public string Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                this.teacher = value;
            }
        }
        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }
        
    }
}