using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace SDA_46337z_MyProject
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Stack<double>> gradesOfStudents = new Dictionary<string, Stack<double>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
        
            string stud = student.Text;

            if (stud.Length == 0 ||
                grade.Text.Length == 0)
            {
                MessageBox.Show("Моля, попълнете всички полета!");
            }

            if (!gradesOfStudents.ContainsKey(stud))
            {
                gradesOfStudents.Add(stud, new Stack<double>());
            }
            
            gradesOfStudents[stud].Push(double.Parse(grade.Text));
          
            richTextBox1.Text += String.Format("Ученик: {0}\nОценка: {1}\n", stud, double.Parse(grade.Text).ToString("0.00"));

            student.Text = "";
            grade.Text = "";
        }

        private void avgBtn_Click(object sender, EventArgs e)
        {
            double avg = 0;
            
            foreach(KeyValuePair<string, Stack<double>> kvp in gradesOfStudents)
            {
                foreach(double grade in kvp.Value)
                {
                    avg += grade;
                }
                avg /= kvp.Value.Count;
                richTextBox1.Text += String.Format("Среден успех на ученик {0} e {1}.\n", kvp.Key, avg.ToString("0.00"));
                avg = 0;
            }
        }
    }
}