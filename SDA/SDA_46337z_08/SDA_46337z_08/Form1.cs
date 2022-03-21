using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46337z_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            CSet setA = new CSet();
            CSet setB = new CSet();
            CSet setC = new CSet();

            string a = tbA.Text.TrimEnd();
            string b = tbB.Text.TrimEnd();

            string[] tempA = a.Split();
            string[] tempB = b.Split();
            foreach(string item in tempA)
            {
                setA.Add(item);
            }
            foreach(string item in tempB)
            {
                setB.Add(item);
            }
            setC = setA.Union(setB);

            richTextBox1.Text += String.Format("Множеството А = {0}\n", setA.ToString());
            richTextBox1.Text += String.Format("Множеството B = {0}\n", setB.ToString());

            richTextBox1.Text += String.Format("{0} обединение {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());

            setC = setA.Intersection(setB);
            richTextBox1.Text += String.Format("{0} сечение {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());

            setC = setA.Difference(setB);
            richTextBox1.Text += String.Format("{0} разлика {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());
            
            setC = setB.Difference(setA);
            richTextBox1.Text += String.Format("{0} разлика {1} = {2}\n", setA.ToString(), setB.ToString(), setC.ToString());

            if (setB.IsSubset(setA))
            {
                richTextBox1.Text += String.Format("{0} е подмножество на {1}\n", setB.ToString(), setA.ToString());
            } else
            {
                richTextBox1.Text += String.Format("{0} не е подмножество на {1}\n", setB.ToString(), setA.ToString());
            }
        }
    }
}
