using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46337z_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BulStat myBS = new BulStat();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string companyName = tbCompanyName.Text;
            string bs = tbBulStat.Text;

            if (companyName.Length == 0)
            {
                MessageBox.Show("Полето [Фирма] е празно!");
            } else if (bs.Length == 0)
            {
                MessageBox.Show("Полето [БУЛСТАТ] е празно!");
            } else if (!myBS.Contains(companyName))
            {
                myBS.Add(companyName, bs);
                tbBulStat.Text = "";
                tbCompanyName.Text = "";
            } else
            {
                MessageBox.Show(String.Format("Фирмата [{0}] вече е въведена!", companyName));
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            string companyName = tbCompanyName.Text;

            if(companyName.Length == 0)
            {
                MessageBox.Show("Полето [Фирма] е празно!");
            } else if (myBS.Contains(companyName))
            {
                richTextBox1.Text += String.Format("Фимра: {0} - БУЛСТАТ: {1}\n",
                    companyName, myBS.Item(companyName));
            } else
            {
                MessageBox.Show(String.Format("Фирма с име [{0}] не съществува в речника.", companyName));
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += String.Format("Брой елементи в речника: {0}\n", myBS.Count);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string companyName = tbCompanyName.Text;
            myBS.Remove(companyName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myBS.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += myBS.ShowDictionary();
        }
    }
}
